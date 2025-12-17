using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 取得使用者選取的檔案名稱，並指派給輸出參數 fileName。
        // 行為：
        // - 使用設計器中定義的 openFile (OpenFileDialog) 顯示檔案選取對話框
        // - 預設篩選為文字檔與所有檔案，初始資料夾為 我的文件
        // - 使用者按下「確定」時將選取的檔名指派給 fileName；取消則傳回空字串
        private void GetFileName(out string fileName)
        {
            fileName = string.Empty;

            // 設定 OpenFileDialog 屬性（可依需求微調）
            this.openFile.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            this.openFile.Title = "選取國家清單檔案";
            this.openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.openFile.FileName = string.Empty;

            // 顯示對話框並處理使用者回應
            if (this.openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = this.openFile.FileName;
            }
            else
            {
                // 使用者取消或關閉視窗，保持 fileName 為空字串
                fileName = string.Empty;
            }
        }

        // 讀取傳入的檔案並在 countriesListBox 中顯示內容。
        // 行為：
        // - 若檔案不存在或檔名為空則直接返回
        // - 以預設編碼讀取所有行（每行視為一或多個項目）
        // - 若某行包含逗號，會將該行以逗號拆分成多個項目並 individual 加入清單
        // - 發生例外時以 MessageBox 顯示錯誤資訊
        private void GetCountries(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                // 無檔名，直接返回（可視需求顯示提示）
                return;
            }

            if (!File.Exists(fileName))
            {
                MessageBox.Show("找不到檔案：" + fileName, "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 讀取所有行（使用系統預設編碼以支援各種簡單文字檔）
                string[] lines = File.ReadAllLines(fileName, Encoding.Default);

                // 清除現有項目，避免重複
                this.countriesListBox.Items.Clear();

                foreach (var rawLine in lines)
                {
                    if (string.IsNullOrWhiteSpace(rawLine))
                        continue;

                    string line = rawLine.Trim();

                    // 若該行包含逗號，視為逗號分隔的多項目（例如 "USA, Canada, Mexico"）
                    if (line.Contains(","))
                    {
                        var parts = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var part in parts)
                        {
                            var item = part.Trim();
                            if (!string.IsNullOrEmpty(item))
                                this.countriesListBox.Items.Add(item);
                        }
                    }
                    else
                    {
                        // 單行即為單一項目
                        this.countriesListBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // 顯示詳細錯誤訊息以利除錯
                MessageBox.Show("讀取檔案時發生錯誤：\n" + ex.Message, "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;
            GetFileName(out fileName);
            GetCountries(fileName);
        }

         private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
