﻿using Common;
using ResourceLib.Method;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MultiLanEditor
{
    public partial class FrmEditor : Form
    {
        /// <summary>
        ///     多语言字典
        ///     语种 VS 语种字典（单词标示 VS 表示文本）
        /// </summary>
        private readonly Dictionary<string, Dictionary<string, string>> _multiLanguageDictionary =
            new Dictionary<string, Dictionary<string, string>>();

        public FrmEditor()
        {
            InitializeComponent();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            var MonoMode = Type.GetType("Mono.Runtime") != null;
            if (MonoMode)
            {
                Font = GuiConfig.GetMonoFont(this.Font);
                Text = "Multi Language Editor";
            }
            cmbLanguage.SelectedIndexChanged += CmbLanguage_SelectedIndexChanged;
            lstMultiLan.DoubleClick += LstMultiLan_DoubleClick; 
        }

        private void LstMultiLan_DoubleClick(object sender, EventArgs e)
        {
            var SelectedItem = lstMultiLan.SelectedItems[0];
            lblUUID.Text = SelectedItem.Text;
            txtTranslation.Text = SelectedItem.SubItems[1].Text;
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //将数据放入ListView视图
            lstMultiLan.Clear();
            //Header
            lstMultiLan.Columns.Add("统一标示");
            lstMultiLan.Columns.Add(_multiLanguageDictionary.Keys.ElementAt(cmbLanguage.SelectedIndex));
            //Details
            for (var i = 0; i < uuiDs.Count; i++)
            {
                var item = new ListViewItem(uuiDs[i]);
                for (var j = 0; j < _multiLanguageDictionary.Keys.Count; j++)
                {
                    if (_multiLanguageDictionary[_multiLanguageDictionary.Keys.ElementAt(cmbLanguage.SelectedIndex)].ContainsKey(uuiDs[i]))
                    {
                        item.SubItems.Add(_multiLanguageDictionary[_multiLanguageDictionary.Keys.ElementAt(cmbLanguage.SelectedIndex)][uuiDs[i]]);
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                }
                lstMultiLan.Items.Add(item);
            }
            UIAssistant.ListViewColumnResize(lstMultiLan);
        }

        List<string> uuiDs = new List<string>();

        private void btnImport_Click(object sender, EventArgs e)
        {
            cmbLanguage.Items.Clear();
            //整体表格
            var multilanFolder = ctlMultiLanFolder.SelectedPathOrFileName;
            //整理出最大列表，防止文件之间出现单词表格不同
            uuiDs.Clear();
            if (!string.IsNullOrEmpty(multilanFolder))
            {
                //便利整个文件夹，获得语言字典
                foreach (var filename in Directory.GetFiles(multilanFolder))
                {
                    StringResource.InitLanguage(filename);
                    var singleDic = new Dictionary<string, string>();
                    foreach (var item in StringResource.StringDic)
                    {
                        if (!uuiDs.Contains(item.Key)) uuiDs.Add(item.Key);
                        singleDic.Add(item.Key, item.Value);
                    }
                    _multiLanguageDictionary.Add(StringResource.LanguageType, singleDic);
                    cmbLanguage.Items.Add(StringResource.LanguageType);
                }
            }
            cmbLanguage.SelectedIndex = 0;
        }
    }
}