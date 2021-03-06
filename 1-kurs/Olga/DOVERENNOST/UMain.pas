unit UMain;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, FireDAC.Stan.Intf, FireDAC.Stan.Option,
  FireDAC.Stan.Error, FireDAC.UI.Intf, FireDAC.Phys.Intf, FireDAC.Stan.Def,
  FireDAC.Stan.Pool, FireDAC.Stan.Async, FireDAC.Phys, FireDAC.VCLUI.Wait,
  FireDAC.Stan.Param, FireDAC.DatS, FireDAC.DApt.Intf, FireDAC.DApt,
  Vcl.StdCtrls, Vcl.Buttons, Vcl.ComCtrls, Data.DB, FireDAC.Comp.DataSet,
  FireDAC.Comp.Client, Vcl.ExtCtrls, Vcl.Menus, FireDAC.Phys.SQLite,
  FireDAC.Phys.SQLiteDef, FireDAC.Stan.ExprFuncs, Vcl.Grids, dateutils,
  Vcl.DBGrids, comobj, FireDAC.Phys.SQLiteWrapper.Stat, ustr;

type
  TForm1 = class(TForm)
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    Panel1: TPanel;
    FDConnection1: TFDConnection;
    Query1: TFDQuery;
    PageControl1: TPageControl;
    StatusBar1: TStatusBar;
    TabSheet1: TTabSheet;
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    BitBtn3: TBitBtn;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    StringGrid2: TStringGrid;
    Label11: TLabel;
    ���������: TTabSheet;
    Edit1: TEdit;
    Button1: TButton;
    DateTimePicker1: TDateTimePicker;
    DateTimePicker2: TDateTimePicker;
    ComboBox1: TComboBox;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    ComboBox2: TComboBox;
    ComboBox3: TComboBox;
    BitBtn4: TBitBtn;
    FDTable1: TFDTable;
    Edit6: TEdit;
    DataSource1: TDataSource;
    StringGrid1: TStringGrid;
    Query2: TFDQuery;
    Query3: TFDQuery;
    BitBtn5: TBitBtn;
    BitBtn6: TBitBtn;
    ComboBox4: TComboBox;
    ComboBox5: TComboBox;
    Label12: TLabel;
    Query4: TFDQuery;
    DBGrid1: TDBGrid;
    DataSource2: TDataSource;
    FDTable2: TFDTable;
    N2: TMenuItem;
    procedure BitBtn1Click(Sender: TObject);
    procedure FormActivate(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure BitBtn2Click(Sender: TObject);
    procedure BitBtn4Click(Sender: TObject);
    procedure DBGrid1DrawDataCell(Sender: TObject; const [Ref] Rect: TRect;
      Field: TField; State: TGridDrawState);
    procedure auto(stringgridn:tstringgrid);
    procedure FDTable1AfterOpen(DataSet: TDataSet);
    procedure FDTable1AfterRefresh(DataSet: TDataSet);
    procedure fillstrgr(strgr:tstringgrid; q:tfdquery);
    procedure StringGrid2SelectCell(Sender: TObject; ACol, ARow: Integer;
      var CanSelect: Boolean);
    procedure StringGrid1Click(Sender: TObject);
    procedure BitBtn5Click(Sender: TObject);
    procedure BitBtn3Click(Sender: TObject);
    procedure BitBtn6Click(Sender: TObject);
    procedure FDTable2AfterPost(DataSet: TDataSet);
    procedure N2Click(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

uses ABOUT;

procedure TForm1.fillstrgr(strgr:tstringgrid; q:tfdquery);
 var
  i:integer;
  begin
   for i:=1 to strgr.RowCount-1 do strgr.Rows[i].Clear;
   for i:=1 to strgr.ColCount-1 do strgr.Cols[i].Clear;
   strgr.RowCount:=2;
   strgr.ColCount:=q.Fields.Count;
   while not(q.Eof) do
    begin
     for i:=0 to q.Fields.Count-1 do
      strgr.Cells[i,strgr.RowCount-1]:=q.Fields.Fields[i].AsString;
     q.Next;
     strgr.RowCount:=strgr.RowCount+1;
    end;
   if strgr.RowCount>2 then strgr.RowCount:=strgr.RowCount-1;
  end;


procedure TForm1.auto(stringgridn:tstringgrid);
 var
  x, y, w: integer;
  MaxWidth: integer;
begin
    with StringGridn do
    begin
      for x := 0 to ColCount - 1 do
      begin
        MaxWidth := 0;
        for y := 0 to RowCount - 1 do
        begin
          w := Canvas.TextWidth(Cells[x,y]);
          if w > MaxWidth then
            MaxWidth := w;
        end;
        ColWidths[x] := MaxWidth + 8;
      end;
    end;
end;


procedure TForm1.BitBtn1Click(Sender: TObject);
var
    Year, Month, Day: Word;
    i:integer;
begin
 Edit1.Text:='';
 Button1.Click;
 Datetimepicker1.Date:=Date;
 DecodeDate(Date, Year, Month, Day);
 Datetimepicker2.Date:=EndofAMonth(Year, Month);
 Combobox1.Text:='';
 EDit2.Text:='';
 Edit3.Text:='';
 Edit4.Text:='';
 EDit5.Text:='';
 ComboBox2.Text:='';
 Combobox3.Text:='';
 for i:=1 to 9 do
    begin
     Stringgrid2.Cells[0,i]:='';
     Stringgrid2.Cells[1,i]:='';
     Stringgrid2.Cells[2,i]:='';
    end;
end;

procedure TForm1.BitBtn2Click(Sender: TObject);
var
 s,s1,s2:string;
 i:integer;
begin
   s:='select * from dover where id='+edit1.Text;
   Query1.Close;
   Query1.SQL.Clear;
   Query1.SQL.Add(s);
   Query1.Open();
   if Query1.RecordCount<>0 then
   begin
      // �������
     Query1.Close;
     Query1.SQL.Clear;
     Query1.SQL.Add('delete from dover where id='+edit1.text);
     Query1.Execsql;
     Query1.Close;
     Query1.SQL.Clear;
     Query1.SQL.Add('delete from cen where numdov='+edit1.text);
     Query1.Execsql;
   end;
   // ���������
   s:= 'insert into dover(id,num_work,mesto,osn,datebeg,dateend,dop1,dop2) values(';
   s:=s+Edit1.Text+','+edit6.Text+',';
   s:=s+Quotedstr(ComboBox2.text)+',';
   s:=s+Quotedstr(ComboBox3.text)+',';
   s:=s+Quotedstr(Datetostr(datetimepicker1.Date))+',';
   s:=s+Quotedstr(datetostr(datetimepicker2.Date))+',';
   s1:=Combobox4.Text;
   s2:=combobox5.Text;
   s:=s+Quotedstr(s1)+','+Quotedstr(s2)+');';
   Query1.Close;
   Query1.SQL.Clear;
   Query1.SQL.Add(s);
   Query1.ExecSQL;
   Query1.Close;

   for i:=1 to 9  do
    if Stringgrid2.Cells[0,i]<>'' then

    begin

     s:='insert into cen(numdov,name,edizm,kolvo,dop)values(';
     s:=s+Edit1.text+',';
     s:=s+Quotedstr(Stringgrid2.Cells[0,i])+',';
     s:=s+Quotedstr(Stringgrid2.Cells[1,i])+',';
     s:=s+Quotedstr(Stringgrid2.Cells[2,i])+',';
     s:=s+Quotedstr('')+');';


     Query3.Close;
     Query3.SQL.Clear;
     Query3.SQL.Add(s);
     Query3.ExecSQL;
     Query3.Close;
 
    end;
  
 //BitBtn4.Click;
end;

procedure TForm1.BitBtn3Click(Sender: TObject);
var
 Ap : Variant;
 fn,mon:string;
 d,m,y,i:word;
 td:tdate;
 s:string;
begin
 BitBtn2.Click;
 try
  Ap := GetActiveOleObject('Excel.Application');
 except
  Ap := CreateOleObject('Excel.Application');
 end;
 fn:=''+extractfilepath(paramstr(0))+'DOVER.xlsx';
 Ap.Workbooks.Open(fn);
 Ap.Visible:=true;
 //Ap.Cells[1,1] := '���������';
 mon:=strmonthd(Datetimepicker2.date,false);
 td:= Datetimepicker2.date;
 Decodedate(td,y,m,d);
 Ap.Cells[6,8] := inttostr(d);
 Ap.Cells[6,10] := mon;
 Ap.Cells[6,20] := inttostr(y);
 Ap.Cells[14,12] := EDit1.text;
 td:= Datetimepicker1.date;
 Decodedate(td,y,m,d);
 s:=inttostr(d)+'  '+strmonthd(Datetimepicker1.date,false)+'  '+inttostr(y)+'�.';
 Ap.Cells[15,5] := s;

 Ap.Cells[16,4] := Combobox1.text;
 // passport

  Ap.Cells[18,5] := EDit2.text;
  Ap.Cells[18,8] := EDit3.text;

 td:= strtodate(edit4.Text);
 Decodedate(td,y,m,d);
 Ap.Cells[18,12] := inttostr(d);
 Ap.Cells[18,14] := strmonthd(td,false);
 Ap.Cells[18,18] := inttostr(y)+'�.';
 Ap.Cells[19,3] := EDit5.text;
 Ap.Cells[21,5] := Combobox2.text;
 Ap.Cells[23,8] := ComboBox3.text;
 Ap.Cells[38,6] := Combobox4.text;
 Ap.Cells[39,7] := Combobox5.text;

 i:=1;
 while stringgrid2.Cells[0,i]<>'' do
  begin
   Ap.Cells[29+i,3] := inttostr(i);
   Ap.Cells[29+i,4] := stringgrid2.Cells[0,i];
   Ap.Cells[29+i,12] := stringgrid2.Cells[1,i];
   Ap.Cells[29+i,14] := stringgrid2.Cells[2,i];
   inc(i);
  end;


 BitBtn4.Click;
 Ap.ActiveWorkBook.SaveAs(fn+'1');

end;

procedure TForm1.BitBtn4Click(Sender: TObject);
begin
 Query1.Close;
 Query1.SQL.Clear;
 Query1.Open('select * from worker order by fio');
 Combobox1.Items.Clear;
 while not (Query1.Eof) do
  begin
   Combobox1.Items.Add(Query1.fieldbyname('fio').AsString);
   Query1.Next;
  end;

 Query1.Close;
 Query1.SQL.Clear;
 Query1.Open('select distinct(mesto) from dover order by mesto');
 Combobox2.Items.Clear;
 while not (Query1.Eof) do
  begin
   Combobox2.Items.Add(Query1.fieldbyname('mesto').AsString);
   Query1.Next;
  end;

 Query1.Close;
 Query1.SQL.Clear;
 Query1.Open('select distinct(osn) from dover order by osn');
 Combobox3.Items.Clear;
 while not (Query1.Eof) do
  begin
   Combobox3.Items.Add(Query1.fieldbyname('osn').AsString);
   Query1.Next;
  end;

 Query2.Close;
 Query2.Open();
 fillstrgr(stringgrid1, query2);
 auto(Stringgrid1);
 Query2.Close;
 Query1.Close;
 Query4.Close;
 Combobox4.Text:='';
 Combobox5.Text:='';
 Query4.Close;
 Query4.SQL.Clear;
 Query4.Open('select distinct(dop1) dop1 from dover');
 Combobox4.Items.Clear;
 while not (Query4.Eof) do
  begin
   Combobox4.Items.Add(Query4.fieldbyname('dop1').AsString);
   Query4.Next;
  end;
 Query4.Close;
 Query4.SQL.Clear;
 Query4.Open('select distinct(dop2) dop2 from dover');
 Combobox5.Items.Clear;
 while not (Query4.Eof) do
  begin
   Combobox5.Items.Add(Query4.fieldbyname('dop2').AsString);
   Query4.Next;
  end;



end;

procedure TForm1.BitBtn5Click(Sender: TObject);
var
 i:integer;
begin
if MessageDlg('������������� ������� ���������� ������������?',mtError, mbYesNo, 0)=mrYes then
 begin
  Query1.Close;
  Query1.SQL.Clear;
  Query1.SQL.Add('delete from dover where id='+Stringgrid1.Cells[0,Stringgrid1.row]);
  Query1.ExecSQL;
  for I := 1 to 9 do
 Stringgrid2.Rows[i].Clear;
  BitBtn4.Click;

 end;
end;

procedure TForm1.BitBtn6Click(Sender: TObject);
begin
Query1.Close;
Query1.SQL.Clear;
Query1.SQL.Add('update worker set ');
Query1.SQL.Add('fio='+Quotedstr(Combobox1.text));
Query1.SQL.Add(', pb='+Quotedstr(EDit2.text));
Query1.SQL.Add(', pn='+Quotedstr(EDit3.text));
Query1.SQL.Add(' , pd='+Quotedstr(EDit4.text));
Query1.SQL.Add(', po='+Quotedstr(EDit5.text));
Query1.SQL.Add('Where num='+edit6.text);
Query1.ExecSQL;
BitBtn4.Click;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
 Query1.Close;
 Query1.SQL.Clear;
 Query1.Open('select max(id)+1 nid from dover');
 while not (Query1.Eof) do
  begin
   edit1.Text:=Query1.fieldbyname('nid').AsString;
   Query1.Next;
  end;
 Query1.Close;
end;

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
Query1.Close;
 Query1.SQL.Clear;
 Query1.Open('select * from worker where upper(fio)='+Quotedstr(UpperCase(Combobox1.Text)));
 Edit2.Text:=Query1.fieldbyname('pb').AsString;
 Edit3.Text:=Query1.fieldbyname('pn').AsString;
 Edit4.Text:=Query1.fieldbyname('pd').AsString;
 Edit5.Text:=Query1.fieldbyname('po').AsString;
 Edit6.Text:=Query1.fieldbyname('num').AsString;
end;

procedure TForm1.DBGrid1DrawDataCell(Sender: TObject; const [Ref] Rect: TRect;
  Field: TField; State: TGridDrawState);
var
   Grid         : TStringGrid;
   Texto   : String;
   Rectangulo   : TRect;
 begin
   Rectangulo:=Rect;
   Grid := TStringGrid(Sender);
   if Field.IsBlob then
   begin
     Grid.Canvas.FillRect(Rect);
     Texto := Field.AsString;
     DrawText( Grid.Canvas.Handle,
               PChar(Texto),
               StrLen(PChar(Texto)),
               Rectangulo,
               DT_WORDBREAK);
   end;
end;

procedure TForm1.FDTable1AfterOpen(DataSet: TDataSet);
begin
 Dataset.Last;
end;

procedure TForm1.FDTable1AfterRefresh(DataSet: TDataSet);
begin
 Dataset.Last;
end;

procedure TForm1.FDTable2AfterPost(DataSet: TDataSet);
begin
BitBtn4.Click;
end;

procedure TForm1.FormActivate(Sender: TObject);
begin
 Form1.Icon:=Application.Icon;
 FDConnection1.Connected:=true;
 Fdtable1.Active:=true;
 Fdtable2.Active:=true;
 Stringgrid2.Cells[0,0]:='������������ ��������';
 Stringgrid2.Cells[1,0]:='������� ���.';
 Stringgrid2.Cells[2,0]:='����������';
 auto(Stringgrid2);

 BitBtn4.Click;
 BitBtn1.Click;
end;

procedure TForm1.N2Click(Sender: TObject);
begin
 AboutBox.ShowModal;
end;

procedure TForm1.StringGrid1Click(Sender: TObject);
var
 i:integer;
begin
 ///  �������� ������� � ����
 ///
 Query1.Close;
 Query1.SQL.Clear;
 Query1.Open('select * from worker where num='+Stringgrid1.Cells[6,Stringgrid1.row]);
 Edit1.Text:=Stringgrid1.Cells[0,Stringgrid1.row];
 ComboBox1.Text:=Stringgrid1.Cells[1,Stringgrid1.row];
 Datetimepicker1.Date:=  strtodate(Stringgrid1.Cells[2,Stringgrid1.row]);
 Datetimepicker2.Date:=  strtodate(Stringgrid1.Cells[3,Stringgrid1.row]);
 Edit2.Text:=Query1.FieldByName('pb').asstring;
 Edit3.Text:=Query1.FieldByName('pn').asstring;
 Edit4.Text:=Query1.FieldByName('pd').asstring;
 Edit5.Text:=Query1.FieldByName('po').asstring;
 Edit6.Text:=Query1.FieldByName('num').asstring;
 Combobox2.Text:=Stringgrid1.Cells[4,Stringgrid1.row];
 Combobox3.Text:=Stringgrid1.Cells[5,Stringgrid1.row];
 Combobox4.Text:=Stringgrid1.Cells[7,Stringgrid1.row];
 Combobox5.Text:=Stringgrid1.Cells[8,Stringgrid1.row];

 for I := 1 to 9 do
 Stringgrid2.Rows[i].Clear;
 Query1.Close;
 Query1.SQL.Clear;
 Query1.Open('select * from cen where numdov='+Stringgrid1.Cells[0,Stringgrid1.row]);
 i:=1;
 while not (Query1.Eof) do
  begin
   Stringgrid2.Cells[0,i]:=Query1.FieldByName('name').AsString;
   Stringgrid2.Cells[1,i]:=Query1.FieldByName('edizm').AsString;
   Stringgrid2.Cells[2,i]:=Query1.FieldByName('kolvo').AsString;
   Query1.Next;
   inc(i);
  end;

 Query1.Close;

end;

procedure TForm1.StringGrid2SelectCell(Sender: TObject; ACol, ARow: Integer;
  var CanSelect: Boolean);
begin
auto(Stringgrid2);
end;

end.
