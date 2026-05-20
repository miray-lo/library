using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liberary
{
    public partial class Form1 : Form
    {
        // 1. 設定共用成員變數陣列
        string[] b_name = { "三國演義", "西遊記", "唐詩三百首", "楚辭", "西廂記", "水滸傳", "紅樓夢", "牡丹亭" };
        string[] author = { "羅貫中", "吳承恩", "孫洙", "劉向", "王實甫", "施耐庵", "曹雪芹", "湯顯祖" };
        string[] kind = { "章回小說", "章回小說", "詩選", "詩歌", "戲曲", "章回小說", "章回小說", "戲曲" };

        public Form1()
        {
            InitializeComponent();
        }

        // 2. 當表單載入時，將資料匯入至畫面
        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化 ComboBox 選項
            cmbView.Items.Add("大圖示");
            cmbView.Items.Add("詳細資料");
            cmbView.Items.Add("小圖示");
            cmbView.Items.Add("清單");
            cmbView.Items.Add("大圖示加詳細資料");
            cmbView.SelectedIndex = 0; // 預設選取第一個項目

            // 設定 ListView 的欄位名稱與寬度
            lvwBooks.Columns.Add("書名", 100);
            lvwBooks.Columns.Add("作者", 60);
            lvwBooks.Columns.Add("類別", 60);

            lvwBooks.BeginUpdate(); // 暫停重繪

            // 透過迴圈將陣列資料加入 ListView
            for (int i = 0; i < b_name.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(b_name[i]); // 宣告一個ListViewItem物件
                lvi.SubItems.Add(author[i]); // 新增作者欄位資料
                lvi.SubItems.Add(kind[i]); // 新增類別欄位資料
                lvwBooks.Items.Add(lvi); // 新增項目
                lvwBooks.Items[i].ImageIndex = i; // 指定影像的索引值
            }

            lvwBooks.EndUpdate(); // 重繪
        }

        // 3. 當切換檢視方式，讓 ListView 改變檢視模式
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 根據 cmbView 的 SelectedIndex 屬性值，設定檢視方式
            switch (cmbView.SelectedIndex)
            {
                case 0: // 大圖示
                    lvwBooks.View = View.LargeIcon;
                    break;
                case 1: // 詳細資料
                    lvwBooks.View = View.Details;
                    break;
                case 2: // 小圖示
                    lvwBooks.View = View.SmallIcon;
                    break;
                case 3: // 清單
                    lvwBooks.View = View.List;
                    break;
                case 4: // 大圖示加詳細資料
                    lvwBooks.View = View.Tile;
                    break;
            }
        }

        // 4. ItemActivate 事件，雙擊書籍觸發
        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            // 取得書名
            string strBookname = b_name[lvwBooks.SelectedIndices[0]];

            // 檢查是否已經存在於借書清單中
            bool exist = lstBorrow.Items.Contains(strBookname);

            if (exist != true) // 若選取的書名不存在借書清單中
            {
                // 跳出確認視窗
                DialogResult dr = MessageBox.Show("確定要借閱嗎?", strBookname, MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes) // 若按 <是> 鈕
                {
                    // 新增項目到借書清單
                    lstBorrow.Items.Add(strBookname);
                }
            }
        }

        // 如果之前的舊點擊事件在 Designer 還有殘留，留著這個空方法避免報錯
        private void lvwBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}