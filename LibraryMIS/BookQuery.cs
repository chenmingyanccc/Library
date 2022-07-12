using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS
{
	/// <summary>
	/// BookQuery 的摘要说明。
	/// </summary>
	public class BookQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textWriter;
		private System.Windows.Forms.Button btQuery;
		private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btClose;
        private IContainer components;
        private Button btbaobiao;
		private SqlConnection oleConnection1 = null;

		public BookQuery()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label9 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textWriter = new System.Windows.Forms.TextBox();
            this.btQuery = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btbaobiao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowSorting = false;
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 10F);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid1.Location = new System.Drawing.Point(11, 103);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(757, 288);
            this.dataGrid1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(73, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "图书编号";
            // 
            // textID
            // 
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textID.Location = new System.Drawing.Point(148, 21);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(133, 25);
            this.textID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "图书名";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Location = new System.Drawing.Point(363, 21);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(133, 25);
            this.textName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(512, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "作者";
            // 
            // textWriter
            // 
            this.textWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textWriter.Location = new System.Drawing.Point(555, 21);
            this.textWriter.Name = "textWriter";
            this.textWriter.Size = new System.Drawing.Size(133, 25);
            this.textWriter.TabIndex = 27;
            // 
            // btQuery
            // 
            this.btQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQuery.Location = new System.Drawing.Point(63, 62);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(100, 29);
            this.btQuery.TabIndex = 28;
            this.btQuery.Text = "查询";
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btClear
            // 
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClear.Location = new System.Drawing.Point(244, 62);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 29);
            this.btClear.TabIndex = 29;
            this.btClear.Text = "清空";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(436, 62);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 29);
            this.btClose.TabIndex = 30;
            this.btClose.Text = "退出";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btbaobiao
            // 
            this.btbaobiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbaobiao.Location = new System.Drawing.Point(620, 62);
            this.btbaobiao.Name = "btbaobiao";
            this.btbaobiao.Size = new System.Drawing.Size(100, 29);
            this.btbaobiao.TabIndex = 31;
            this.btbaobiao.Text = "报表输出";
            this.btbaobiao.Click += new System.EventHandler(this.btbaobiao_Click);
            // 
            // BookQuery
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(847, 432);
            this.Controls.Add(this.btbaobiao);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textWriter);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGrid1);
            this.Name = "BookQuery";
            this.Text = "图书查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        DataSet1 ds=new DataSet1();
		private void btQuery_Click(object sender, System.EventArgs e)
		{
            //string sql1 = "(BNum-(select count(*) from bookOut where ";
			string sql = "select BID as 图书编号,BName as 图书名,BWriter as 作者,BPublish as 出版社,BDate as 出版日期,BPrice as 价格,"+
				"BNum as 数量,type as 类型,BRemark as 备注 ";
			if (textID.Text.Trim() != "")
			{
                //sql1 = sql1+" BID= "+"'"+textID.Text.Trim()+"')) as 库存数量 ";
				sql = sql+"from book where BID= "+"'"+textID.Text.Trim()+"'";
			}	
			else if (textName.Text.Trim() != "")
			{
                //sql1 = sql1+" BID=(select BID from book where BName='"+textName.Text+"'))) as 库存数量 ";
				sql = sql+"from book where BName= "+"'"+textName.Text+"'";
			}
			else if (textWriter.Text.Trim() != "")
			{
                //sql1 = sql1+" BID=(select BID from book where BWriter='"+textWriter.Text+"'))) as 库存数量 ";
				sql = sql+"from book where BWriter= "+"'"+textWriter.Text+"'";
			}
			else
			{
				MessageBox.Show("请输入查询条件","提示");
				return;
			}

			oleConnection1.Open();
			SqlDataAdapter adp = new SqlDataAdapter(sql,oleConnection1);

            ds.Clear();
			adp.Fill(ds,"book");
			dataGrid1.DataSource=ds.Tables[0].DefaultView;
			dataGrid1.CaptionText="共有"+ds.Tables[0].Rows.Count+"条查询记录";
			oleConnection1.Close();
		}

		private void btClear_Click(object sender, System.EventArgs e)
		{
			textID.Text="";
			textName.Text="";
			textWriter.Text="";
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void btbaobiao_Click(object sender, EventArgs e)
        {
            PrintCYReport pr = new PrintCYReport(ds);
            pr.Show();
        }

	}
}
