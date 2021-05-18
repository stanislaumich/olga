unit UMain;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, FireDAC.Stan.Intf, FireDAC.Stan.Option,
  FireDAC.Stan.Error, FireDAC.UI.Intf, FireDAC.Phys.Intf, FireDAC.Stan.Def,
  FireDAC.Stan.Pool, FireDAC.Stan.Async, FireDAC.Phys, FireDAC.Phys.SQLite,
  FireDAC.Phys.SQLiteDef, FireDAC.Stan.ExprFuncs, FireDAC.VCLUI.Wait, Data.DB,
  FireDAC.Comp.Client, FireDAC.Stan.Param, FireDAC.DatS, FireDAC.DApt.Intf,
  FireDAC.DApt, FireDAC.Comp.DataSet, Vcl.ComCtrls, Vcl.StdCtrls, Vcl.Grids,
  Vcl.DBGrids, Vcl.ExtCtrls, Vcl.Buttons, Vcl.MPlayer, Vcl.Menus,
  FireDAC.Phys.SQLiteWrapper.Stat;

type
  TForm1 = class(TForm)
    FDC: TFDConnection;
    Query1: TFDQuery;
    GroupBox1: TGroupBox;
    MonthCalendar1: TMonthCalendar;
    GroupBox2: TGroupBox;
    Panel1: TPanel;
    DBGrid1: TDBGrid;
    DataSource1: TDataSource;
    Label1: TLabel;
    Timer1: TTimer;
    Label2: TLabel;
    Queryt: TFDQuery;
    Timer2: TTimer;
    Queryu: TFDQuery;
    Button1: TButton;
    Queryi: TFDQuery;
    Queryz: TFDQuery;
    Queryu1: TFDQuery;
    Timer3: TTimer;
    ComboBox1: TComboBox;
    ComboBox2: TComboBox;
    Label3: TLabel;
    CheckBox1: TCheckBox;
    BitBtn1: TBitBtn;
    BalloonHint1: TBalloonHint;
    TI: TTrayIcon;
    MediaPlayer1: TMediaPlayer;
    BitBtn2: TBitBtn;
    PopupMenu1: TPopupMenu;
    N1: TMenuItem;
    N2: TMenuItem;
    PopupMenu2: TPopupMenu;
    N3: TMenuItem;
    N4: TMenuItem;
    N5: TMenuItem;
    Timer4: TTimer;
    MainMenu1: TMainMenu;
    N6: TMenuItem;
    N7: TMenuItem;
    N8: TMenuItem;
    N9: TMenuItem;
    N10: TMenuItem;
    N11: TMenuItem;
    procedure FormActivate(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure DBGrid1DrawColumnCell(Sender: TObject; const [Ref] Rect: TRect;
      DataCol: Integer; Column: TColumn; State: TGridDrawState);
    procedure Timer1Timer(Sender: TObject);
    procedure Timer2Timer(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Timer3Timer(Sender: TObject);
    procedure CheckBox1Click(Sender: TObject);
    procedure BitBtn1Click(Sender: TObject);
    Procedure OnMinimizeProc(Sender:TObject);
    procedure N2Click(Sender: TObject);
    procedure N1Click(Sender: TObject);
    procedure TIClick(Sender: TObject);
    procedure BitBtn2Click(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure N3Click(Sender: TObject);
    procedure N4Click(Sender: TObject);
    procedure N5Click(Sender: TObject);
    procedure Timer4Timer(Sender: TObject);
    procedure N8Click(Sender: TObject);
    procedure N10Click(Sender: TObject);
    procedure N9Click(Sender: TObject);
    procedure N11Click(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  protected
   Procedure ControlWindow(Var Msg:TMessage);
  end;

var
  Form1: TForm1;
  timer2work,timer3work:boolean;
implementation

{$R *.dfm}

uses Unit2, ABOUT;

procedure TForm1.BitBtn1Click(Sender: TObject);
begin
Queryt.Refresh;
end;

procedure TForm1.BitBtn2Click(Sender: TObject);
begin
// Form1.Close;
FDC.Close;
Application.Terminate;
end;

procedure TForm1.Button1Click(Sender: TObject);
var
 Value:string;
begin
 //Queryi.ParamByName('id').AsString:='NULL';
 Queryi.ParamByName('time').AsString:=Combobox1.text+':'+Combobox2.Text+':00';
 Queryi.ParamByName('date').AsString:=datetostr(MonthCalendar1.Date);
 Queryi.ParamByName('descr').AsString:=datetostr(date)+' '+timetostr(time);
 if InputQuery('�������� �������', '���������:', value) then
  begin
   Queryi.ParamByName('task').AsString:=Value;
   Queryi.ExecSQL;
   Queryt.Refresh;
  end;
end;

procedure TForm1.CheckBox1Click(Sender: TObject);
begin
 if CheckBox1.Checked then Queryt.ParamByName('s').AsInteger:=-1
 else Queryt.ParamByName('s').AsInteger:=0;
 BitBtn1.Click;
end;

procedure TForm1.DBGrid1DrawColumnCell(Sender: TObject; const [Ref] Rect: TRect;
  DataCol: Integer; Column: TColumn; State: TGridDrawState);
const
clPaleGreen = TColor($CCFFCC);
clPaleRed = TColor($CCCCFF);
begin

//If Column.FieldName = 'Status' then //������� ��� �����, ���� ������ ��������� ����� �����
dbgrid1.Canvas.Font.Color:=clBlue;

If Column.Field.Dataset.FieldbyName('Status').AsString = '1'
then
If (gdFocused in State) //����� �� ������ �����?
then
 begin
  dbgrid1.canvas.brush.color := clBlack; //����� �����
  dbgrid1.Canvas.Font.Color:=clWhite;
 end
else
 begin
  dbgrid1.canvas.brush.color := clPaleGreen; //�� ����� ������
  dbgrid1.Canvas.Font.Color:=clBlack;
 end;

If Column.Field.Dataset.FieldbyName('Status').AsString = '0'
then
If (gdFocused in State) //����� �� ������ �����?
then
 begin
  dbgrid1.canvas.brush.color := clWhite; //����� �����
  dbgrid1.Canvas.Font.Color:=clBlack;
 end
else
 begin
  dbgrid1.canvas.brush.color := clskyBlue; //�� ����� ������
  dbgrid1.Canvas.Font.Color:=clBlue;
 end;

If (Column.Field.Dataset.FieldbyName('Status').AsInteger >1) and
  (Column.Field.Dataset.FieldbyName('Status').AsInteger < 5)
then
If (gdFocused in State) //����� �� ������ �����?
then begin
  dbgrid1.canvas.brush.color := clBlack; //����� �����
  dbgrid1.Canvas.Font.Color:=clWhite;
 end //����� �����
else dbgrid1.canvas.brush.color := clYellow; //�� ����� ������

If (Column.Field.Dataset.FieldbyName('Status').AsInteger >4)
then
If (gdFocused in State) //����� �� ������ �����?
then begin
  dbgrid1.canvas.brush.color := clBlack; //����� �����
  dbgrid1.Canvas.Font.Color:=clWhite;
 end //����� �����
else  begin
  dbgrid1.canvas.brush.color := clRed; //�� ����� ������
  dbgrid1.Canvas.Font.Color:=clWhite;
 end;
If (Column.Field.Dataset.FieldbyName('date').AsString = datetostr(date))and
    (Column.Field.Dataset.FieldbyName('time').Asdatetime>time())
then
 begin
  dbgrid1.canvas.brush.color := clsilver; //�������
  dbgrid1.Canvas.Font.Color:=clBlack;
 end;
//������ ������� �������� ������ ��������� ����������� �����:
dbgrid1.DefaultDrawColumnCell(rect,DataCol,Column, State)
end;

Procedure TForm1.OnMinimizeProc(Sender:TObject);
Begin
 PostMessage(Handle,WM_SYSCOMMAND,SC_MINIMIZE,0);
End;


procedure TForm1.FormActivate(Sender: TObject);
begin
 Monthcalendar1.Date:=Date;
 Label2.Caption:=datetostr(date);
 FDC.Connected:=true;
 timer2work:=false;
 timer3work:=false;
 Query1.SQL.Add('CREATE TABLE IF NOT EXISTS tasks ( ');
 Query1.SQL.Add('id INTEGER PRIMARY KEY AUTOINCREMENT, ');
 Query1.SQL.Add('date varchar(30) NOT NULL, ');
 Query1.SQL.Add('time varchar(30) NOT NULL, ');
 Query1.SQL.Add('task varchar(500) NOT NULL, ');
 Query1.SQL.Add('descr varchar(300) NOT NULL, ');
 Query1.SQL.Add('status varchar(10) NOT NULL);');
 Query1.ExecSQL;
 Queryt.ParamByName('s').AsInteger:=-1;
 Queryt.Open();
 Application.onMinimize:=OnMinimizeProc;
 application.Icon:=form1.Icon;
 dbgrid1.Columns[0].Width:=20;
 dbgrid1.Columns[1].Width:=60;
 dbgrid1.Columns[2].Width:=50;
 dbgrid1.Columns[0].Title.caption:='S';
 dbgrid1.Columns[1].Title.caption:='����';
 dbgrid1.Columns[2].Title.caption:='�����';
 dbgrid1.Columns[3].Title.caption:='����������';
 //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 Mediaplayer1.FileName:=extractfilepath(application.ExeName)+'Sound_17196.mp3';

 if paramstr(1)<>'' then
 begin
  Application.OnMinimize(Self);
 end;
 TI.Visible:=true;
end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
begin


 //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
FDC.Close;
Application.Terminate;
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
   CanClose:=False;
   ShowWindow(Handle,SW_HIDE);  // �������� ���������
   ShowWindow(Application.Handle,SW_HIDE);  // �������� ������ � TaskBar'�
end;

procedure TForm1.N10Click(Sender: TObject);
begin
 Button1.Click;
end;

procedure TForm1.N11Click(Sender: TObject);
begin
  Form1.Close;
end;

procedure TForm1.N1Click(Sender: TObject);
begin
 form2.Close;
 ShowWindow(Handle,SW_SHOW);
 ShowWindow(Application.Handle,SW_SHOW);
 PostMessage(Handle,WM_SYSCOMMAND,SC_MAXIMIZE,0);
end;

procedure TForm1.N2Click(Sender: TObject);
begin
 FDC.Close;
 Application.Terminate;
end;

procedure TForm1.N3Click(Sender: TObject);
begin
 Queryz.Close;
 Queryz.ParamByName('id').AsString:=dbgrid1.DataSource.DataSet.FieldByName('id').AsString;
 Queryz.ParamByName('status').AsInteger:=0;// ���������
 Queryz.ExecSQL;
 Queryt.Refresh;
end;

procedure TForm1.N4Click(Sender: TObject);
begin
 Queryz.Close;
 Queryz.ParamByName('id').AsString:=dbgrid1.DataSource.DataSet.FieldByName('id').AsString;
 Queryz.ParamByName('status').AsInteger:=-1;// �������
 Queryz.ExecSQL;
 Queryt.Refresh;
end;

procedure TForm1.N5Click(Sender: TObject);
begin
 Queryz.Close;
 Queryz.ParamByName('id').AsString:=dbgrid1.DataSource.DataSet.FieldByName('id').AsString;
 Queryz.ParamByName('status').AsInteger:=1;// �������
 Queryz.ExecSQL;
 Queryt.Refresh;
end;

procedure TForm1.N8Click(Sender: TObject);
begin
 AboutBox.ShowModal;
end;

procedure TForm1.N9Click(Sender: TObject);
begin
BitBtn1.Click;
end;

procedure TForm1.TIClick(Sender: TObject);
begin
  ShowWindow(Handle,SW_SHOW);
  ShowWindow(Application.Handle,SW_SHOW);
  PostMessage(Handle,WM_SYSCOMMAND,SC_MAXIMIZE,0);
end;

Procedure TForm1.ControlWindow(Var Msg:TMessage);
Begin
 IF (Msg.WParam=SC_MINIMIZE)or (Msg.WParam=SC_CLOSE) then
  Begin
   ShowWindow(Handle,SW_HIDE);  // �������� ���������
   ShowWindow(Application.Handle,SW_HIDE);  // �������� ������ � TaskBar'�
 End else inherited;
End;



procedure TForm1.Timer1Timer(Sender: TObject);
begin
 Label1.Caption:=timetostr(time);
end;

procedure TForm1.Timer2Timer(Sender: TObject);
begin
 if timer3work then exit;
  if form2.Visible then exit;
 timer2work:=true;
 Queryu.Close;
 Queryu.ParamByName('date').AsString:=datetostr(date);
 Queryu.Open;
 while not Queryu.Eof do
  begin
   if strtotime(Queryu.FieldByName('time').AsString)<time() then
    begin
    Form2.Label1.Caption:=Queryu.FieldByName('task').AsString;
    Form2.Caption:='�����������';
     TI.BalloonHint:= Queryu.FieldByName('task').AsString;
     TI.BalloonTitle:= '������� �����������:';
     TI.ShowBalloonHint;
     TI.BalloonTimeout:= -1;
     Form1.FormStyle:=fsStayOnTop;
     //form1.WindowState:=wsMaximized ;
     Form1.FormStyle:=fsNormal;
     try
     Mediaplayer1.Open;
     Mediaplayer1.Play;
     except
      on e:exception do e:=nil;
     end;
     timer4.Enabled:=true;
     Form2.FormStyle:=fsStayonTop;
     if Form2.ShowModal=mrCancel then
      begin
       Queryz.ParamByName('status').AsInteger:=Queryu.FieldByName('status').AsInteger+1;
      end
     else
      begin
       Queryz.ParamByName('status').AsInteger:=0;
      end;
     Queryz.ParamByName('id').AsString:=Queryu.FieldByName('id').Asstring;
     Queryz.ExecSQL;
     Queryu.Next;
     Queryt.Refresh;
     Mediaplayer1.Stop;
     Mediaplayer1.Close;
  end;
end;
 Queryu1.Close;
 timer2work:=false;
end;

procedure TForm1.Timer3Timer(Sender: TObject);
begin
 if timer2work then exit;
 if form2.Visible then exit;
 timer3work:=true;
 Queryu1.Close;
 Queryu1.ParamByName('date').AsString:=datetostr(date);
 Queryu1.Open;
 while not Queryu1.Eof do
  begin
   if strtotime(Queryu1.FieldByName('time').AsString)<time() then
    if Queryu1.FieldByName('status').Asinteger<6*2 then
    begin
     Form2.Label1.Caption:=Queryu1.FieldByName('task').AsString;
     Form2.Caption:='��������� �����������';
     TI.BalloonHint:= Queryu.FieldByName('task').AsString;
     TI.BalloonTitle:= '������� �����������:';
     TI.ShowBalloonHint;
     TI.BalloonTimeout:= -1;
     Form1.FormStyle:=fsStayOnTop;
     //form1.WindowState:=wsMaximized ;
     Form1.FormStyle:=fsNormal;
     try
     Mediaplayer1.Open;
     Mediaplayer1.Play;
      except
      on e:exception do e:=nil;
     end;
     timer4.Enabled:=true;
     Form2.FormStyle:=fsStayonTop;

    if Form2.ShowModal=mrCancel then
      begin
       Queryz.ParamByName('status').AsInteger:=Queryu1.FieldByName('status').AsInteger+1;
      end
     else
      begin
       Queryz.ParamByName('status').AsInteger:=0;
      end;

     Queryz.ParamByName('id').AsString:=Queryu1.FieldByName('id').Asstring;
     Queryz.ExecSQL;

    end;
     Queryu1.Next;
     Queryt.Refresh;
  end;//while
 Queryu1.Close;
 timer3work:=false;
end;

procedure TForm1.Timer4Timer(Sender: TObject);
begin
timer4.Enabled:=false;
Form2.Close;
end;

end.
