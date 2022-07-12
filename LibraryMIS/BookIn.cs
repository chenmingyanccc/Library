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
	/// BookIn 的摘要说明。
	/// </summary>
	public class BookIn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textPrice;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBDate;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textType;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textPublish;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textWriter;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btIn;
		private System.Windows.Forms.TextBox textOutDate;
		private System.Windows.Forms.TextBox textInDate1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Label text;
		private System.Windows.Forms.TextBox textDay;
		private System.Windows.Forms.TextBox textMoney;
		private System.Windows.Forms.TextBox textNow;
		private System.Windows.Forms.TextBox textBigDay;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textPID;
		private SqlConnection oleConnection1 = null;

		public BookIn()
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.textPID = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.text = new System.Windows.Forms.Label();
            this.textBigDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textInDate1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textOutDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textPublish = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textWriter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataGrid1);
            this.groupBox2.Controls.Add(this.textPID);
            this.groupBox2.Controls.Add(this.btClose);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btIn);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBID);
            this.groupBox2.Location = new System.Drawing.Point(8, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "还书";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "图书证号";
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
            this.dataGrid1.Location = new System.Drawing.Point(454, 15);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(58, 25);
            this.dataGrid1.TabIndex = 25;
            this.dataGrid1.Visible = false;
            this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
            // 
            // textPID
            // 
            this.textPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPID.Location = new System.Drawing.Point(72, 24);
            this.textPID.Name = "textPID";
            this.textPID.Size = new System.Drawing.Size(120, 21);
            this.textPID.TabIndex = 27;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(320, 216);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "取消";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(400, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "请按回车";
            // 
            // btIn
            // 
            this.btIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIn.Location = new System.Drawing.Point(112, 216);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(75, 23);
            this.btIn.TabIndex = 23;
            this.btIn.Text = "还书";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.text);
            this.groupBox4.Controls.Add(this.textBigDay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textNow);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textMoney);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textDay);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textInDate1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textOutDate);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textPrice);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBDate);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textType);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textPublish);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textWriter);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBName);
            this.groupBox4.Location = new System.Drawing.Point(8, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 152);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(16, 120);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(56, 16);
            this.text.TabIndex = 34;
            this.text.Text = "规定天数";
            // 
            // textBigDay
            // 
            this.textBigDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBigDay.Location = new System.Drawing.Point(72, 120);
            this.textBigDay.Name = "textBigDay";
            this.textBigDay.ReadOnly = true;
            this.textBigDay.Size = new System.Drawing.Size(100, 21);
            this.textBigDay.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(336, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "今天日期";
            // 
            // textNow
            // 
            this.textNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNow.Location = new System.Drawing.Point(392, 88);
            this.textNow.Name = "textNow";
            this.textNow.ReadOnly = true;
            this.textNow.Size = new System.Drawing.Size(100, 21);
            this.textNow.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(336, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "罚款金额";
            // 
            // textMoney
            // 
            this.textMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMoney.Location = new System.Drawing.Point(392, 120);
            this.textMoney.Name = "textMoney";
            this.textMoney.ReadOnly = true;
            this.textMoney.Size = new System.Drawing.Size(100, 21);
            this.textMoney.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(176, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "超出天数";
            // 
            // textDay
            // 
            this.textDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDay.Location = new System.Drawing.Point(232, 120);
            this.textDay.Name = "textDay";
            this.textDay.ReadOnly = true;
            this.textDay.Size = new System.Drawing.Size(100, 21);
            this.textDay.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(176, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "应还日期";
            // 
            // textInDate1
            // 
            this.textInDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textInDate1.Location = new System.Drawing.Point(232, 88);
            this.textInDate1.Name = "textInDate1";
            this.textInDate1.ReadOnly = true;
            this.textInDate1.Size = new System.Drawing.Size(100, 21);
            this.textInDate1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "借出日期";
            // 
            // textOutDate
            // 
            this.textOutDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOutDate.Location = new System.Drawing.Point(72, 88);
            this.textOutDate.Name = "textOutDate";
            this.textOutDate.ReadOnly = true;
            this.textOutDate.Size = new System.Drawing.Size(100, 21);
            this.textOutDate.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(352, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "价格";
            // 
            // textPrice
            // 
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrice.Location = new System.Drawing.Point(392, 56);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(100, 21);
            this.textPrice.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(176, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "出版日期";
            // 
            // textBDate
            // 
            this.textBDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBDate.Location = new System.Drawing.Point(232, 56);
            this.textBDate.Name = "textBDate";
            this.textBDate.ReadOnly = true;
            this.textBDate.Size = new System.Drawing.Size(100, 21);
            this.textBDate.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(352, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "类型";
            // 
            // textType
            // 
            this.textType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textType.Location = new System.Drawing.Point(392, 24);
            this.textType.Name = "textType";
            this.textType.ReadOnly = true;
            this.textType.Size = new System.Drawing.Size(100, 21);
            this.textType.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "出版社";
            // 
            // textPublish
            // 
            this.textPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPublish.Location = new System.Drawing.Point(72, 56);
            this.textPublish.Name = "textPublish";
            this.textPublish.ReadOnly = true;
            this.textPublish.Size = new System.Drawing.Size(100, 21);
            this.textPublish.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(192, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "作者";
            // 
            // textWriter
            // 
            this.textWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textWriter.Location = new System.Drawing.Point(232, 24);
            this.textWriter.Name = "textWriter";
            this.textWriter.ReadOnly = true;
            this.textWriter.Size = new System.Drawing.Size(100, 21);
            this.textWriter.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "图书名";
            // 
            // textBName
            // 
            this.textBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBName.Location = new System.Drawing.Point(72, 24);
            this.textBName.Name = "textBName";
            this.textBName.ReadOnly = true;
            this.textBName.Size = new System.Drawing.Size(100, 21);
            this.textBName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(208, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "图书编号";
            // 
            // textBID
            // 
            this.textBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBID.Location = new System.Drawing.Point(264, 24);
            this.textBID.Name = "textBID";
            this.textBID.Size = new System.Drawing.Size(120, 21);
            this.textBID.TabIndex = 12;
            this.textBID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBID_KeyDown);
            // 
            // BookIn
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(536, 276);
            this.Controls.Add(this.groupBox2);
            this.Name = "BookIn";
            this.Text = "还书";
            this.Load += new System.EventHandler(this.BookIn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void textBID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
			{
				oleConnection1.Open();
				string sql = "select BName as 图书名,BWriter as 作者,BPublish as 出版社,BDate as 出版日期,BPrice as 价格,type as 类型,"+
					"ODate as 借出日期,(select longTime from identityinfo where identityname=(select identityname from person where PID='"+textPID.Text.Trim()+"'))"+
					" as 最长借书时间,dateAdd('m',最长借书时间,ODate) as 应还日期,DateDiff('d',应还日期,Now) as 超出天数 from book,bookOut where "+
					"book.BID='"+textBID.Text.Trim()+"' and PID='"+textPID.Text.Trim()+"'";
				SqlDataAdapter adp = new SqlDataAdapter(sql,oleConnection1);
				ds = new DataSet();
				ds.Clear();
				adp.Fill(ds,"book");
				dataGrid1.DataSource = ds.Tables["book"].DefaultView;
				if (ds.Tables[0].Rows.Count!=0)
				{
					textBName.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
					textWriter.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
					textPublish.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
					textBDate.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][3].ToString().Trim();
					textPrice.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString().Trim();
					textType.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][5].ToString().Trim();
					textOutDate.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][6].ToString().Trim();
					textBigDay.Text = Convert.ToString(Convert.ToInt16(ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][7].ToString().Trim())*30);
					textInDate1.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][8].ToString().Trim();
					if (Convert.ToInt16(ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][9].ToString().Trim())>0)
					{
						textDay.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][9].ToString().Trim();
						textMoney.Text = Convert.ToString(Convert.ToInt16(textDay.Text)*0.15);
					}
					else
					{
						textDay.Text="0";
						textMoney.Text="0";
					}
					textNow.Text = DateTime.Now.ToString();
					dataGrid1.CaptionText = "共有"+ds.Tables["book"].Rows.Count+"条记录";
				}
				else
					MessageBox.Show("该读者没有借该图书","提示");
				sql = "update person set PMoney=PMoney+'"+textMoney.Text+"' where PID='"+textPID.Text.Trim()+"'";
				SqlCommand cmd = new SqlCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				oleConnection1.Close();
			}
		}

		private void btIn_Click(object sender, System.EventArgs e)
		{
			if (textBID.Text.Trim()==null)
				MessageBox.Show("请填写图书编号","提示");
			else
			{
				oleConnection1.Open();
				string sql = "delete * from bookOut where BID = '"+textBID.Text.Trim()+"'and PID='"+textPID.Text.Trim()+"'";
				SqlCommand cmd = new SqlCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("还书成功","提示");
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void BookIn_Load(object sender, EventArgs e)
        {

        }
        public void DisplayOleDbErrorCollection(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                MessageBox.Show("Index #" + i + "\n" +
                       "Message: " + exception.Errors[i].Message + "\n" +
                     
                       "Source: " + exception.Errors[i].Source + "\n" +
                       "SQL: " + exception.Errors[i].State + "\n");
            }
        }
        private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
        {

        }
        
	}
}
