
// This file has been generated by the GUI designer. Do not modify.
namespace PyBinding.Gui
{
	public partial class PythonOptionsWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label label1;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Table table1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Entry m_ModuleEntry;
		private global::Gtk.CheckButton m_OptimizeCheckBox;
		private global::Gtk.Entry m_PythonOptions;
		private global::Gtk.ComboBox m_RuntimeCombo;
		private global::MonoDevelop.Components.FileEntry m_RuntimeFileEntry;
		private global::Gtk.Label label3;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TreeView m_PathsTreeView;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Button m_AddPathButton;
		private global::Gtk.Button m_RemovePathButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PyBinding.Gui.PythonOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "PyBinding.Gui.PythonOptionsWidget";
			// Container child PyBinding.Gui.PythonOptionsWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\"bold\">Runtime</span>");
			this.label1.UseMarkup = true;
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(12));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Runtime location:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Python _Options:");
			this.label4.UseUnderline = true;
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Default _Module:");
			this.label5.UseUnderline = true;
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.m_ModuleEntry = new global::Gtk.Entry ();
			this.m_ModuleEntry.CanFocus = true;
			this.m_ModuleEntry.Name = "m_ModuleEntry";
			this.m_ModuleEntry.IsEditable = true;
			this.m_ModuleEntry.InvisibleChar = '●';
			this.table1.Add (this.m_ModuleEntry);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.m_ModuleEntry]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.m_OptimizeCheckBox = new global::Gtk.CheckButton ();
			this.m_OptimizeCheckBox.CanFocus = true;
			this.m_OptimizeCheckBox.Name = "m_OptimizeCheckBox";
			this.m_OptimizeCheckBox.Label = global::Mono.Unix.Catalog.GetString ("Optimize byte-code output");
			this.m_OptimizeCheckBox.DrawIndicator = true;
			this.m_OptimizeCheckBox.UseUnderline = true;
			this.table1.Add (this.m_OptimizeCheckBox);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.m_OptimizeCheckBox]));
			w6.TopAttach = ((uint)(4));
			w6.BottomAttach = ((uint)(5));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.m_PythonOptions = new global::Gtk.Entry ();
			this.m_PythonOptions.CanFocus = true;
			this.m_PythonOptions.Name = "m_PythonOptions";
			this.m_PythonOptions.IsEditable = true;
			this.m_PythonOptions.InvisibleChar = '●';
			this.table1.Add (this.m_PythonOptions);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.m_PythonOptions]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.m_RuntimeCombo = global::Gtk.ComboBox.NewText ();
			this.m_RuntimeCombo.Name = "m_RuntimeCombo";
			this.table1.Add (this.m_RuntimeCombo);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.m_RuntimeCombo]));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.m_RuntimeFileEntry = new global::MonoDevelop.Components.FileEntry ();
			this.m_RuntimeFileEntry.Name = "m_RuntimeFileEntry";
			this.table1.Add (this.m_RuntimeFileEntry);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.m_RuntimeFileEntry]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.alignment1.Add (this.table1);
			this.vbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment1]));
			w11.Position = 1;
			w11.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\"bold\">Module Paths</span>");
			this.label3.UseMarkup = true;
			this.vbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label3]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(12));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w13 = new global::Gtk.Viewport ();
			w13.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.m_PathsTreeView = new global::Gtk.TreeView ();
			this.m_PathsTreeView.CanFocus = true;
			this.m_PathsTreeView.Name = "m_PathsTreeView";
			w13.Add (this.m_PathsTreeView);
			this.scrolledwindow1.Add (w13);
			this.hbox1.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.scrolledwindow1]));
			w16.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.m_AddPathButton = new global::Gtk.Button ();
			this.m_AddPathButton.CanFocus = true;
			this.m_AddPathButton.Name = "m_AddPathButton";
			this.m_AddPathButton.UseStock = true;
			this.m_AddPathButton.UseUnderline = true;
			this.m_AddPathButton.Label = "gtk-add";
			this.vbox2.Add (this.m_AddPathButton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.m_AddPathButton]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.m_RemovePathButton = new global::Gtk.Button ();
			this.m_RemovePathButton.Sensitive = false;
			this.m_RemovePathButton.CanFocus = true;
			this.m_RemovePathButton.Name = "m_RemovePathButton";
			this.m_RemovePathButton.UseStock = true;
			this.m_RemovePathButton.UseUnderline = true;
			this.m_RemovePathButton.Label = "gtk-remove";
			this.vbox2.Add (this.m_RemovePathButton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.m_RemovePathButton]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.alignment2.Add (this.hbox1);
			this.vbox1.Add (this.alignment2);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment2]));
			w21.Position = 3;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.label2.MnemonicWidget = this.alignment2;
			this.label4.MnemonicWidget = this.m_PythonOptions;
			this.label5.MnemonicWidget = this.m_ModuleEntry;
			this.Show ();
			this.m_AddPathButton.Clicked += new global::System.EventHandler (this.AddPath_Clicked);
			this.m_RemovePathButton.Clicked += new global::System.EventHandler (this.RemovePath_Clicked);
		}
	}
}