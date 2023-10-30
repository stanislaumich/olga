unit StudentBook;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, System.Actions, Vcl.ActnList, Vcl.Menus,
   FAbout, FAddData, FDataFind, FGraphic, FDataEdit, Vcl.ComCtrls, Vcl.ImgList, Vcl.StdCtrls,
  Vcl.ToolWin, FireDAC.Stan.Intf, FireDAC.Stan.Option, FireDAC.Stan.Error,
  FireDAC.UI.Intf, FireDAC.Phys.Intf, FireDAC.Stan.Def, FireDAC.Stan.Pool,
  FireDAC.Stan.Async, FireDAC.Phys, FireDAC.Stan.Param, FireDAC.DatS,
  FireDAC.DApt.Intf, FireDAC.DApt, Data.DB, FireDAC.Comp.DataSet,
  FireDAC.Comp.Client, Vcl.Grids, Vcl.DBGrids, Data.Win.ADODB, DynamicList,
  VclTee.TeeGDIPlus, VCLTee.TeEngine, Vcl.ExtCtrls, VCLTee.TeeProcs,
  VCLTee.Chart, VCLTee.Series, inifiles, System.ImageList;

type
  TMainForm = class(TForm)
    ActionList1: TActionList;
    MainMenu1: TMainMenu;
    ActionShow: TAction;
    MenuFile: TMenuItem;
    Open: TMenuItem;
    Save: TMenuItem;
    SaveAs: TMenuItem;
    Close: TMenuItem;
    Create: TMenuItem;
    MenuFunction: TMenuItem;
    Add: TMenuItem;
    Find: TMenuItem;
    Edit: TMenuItem;
    Delete: TMenuItem;
    BuildDiagramm: TMenuItem;
    Settings: TMenuItem;
    Background: TMenuItem;
    Font: TMenuItem;
    Help: TMenuItem;
    About: TMenuItem;
    ActionFind: TAction;
    ActionAdd: TAction;
    ActionEdit: TAction;
    ActionDelete: TAction;
    ActionDiagramm: TAction;
    ActionBackgroundColor: TAction;
    ActionFontColor: TAction;
    ActionFontSize: TAction;
    ActionFont: TAction;
    ActionBold: TAction;
    ActionItalic: TAction;
    ActionSorting: TAction;
    ActionTextColor: TAction;
    ActionCellSize: TAction;
    ActionToFont: TAction;
    ActionInfo: TAction;
    ActionFontDec: TAction;
    ActionFontInc: TAction;
    ImageList1: TImageList;
    ToolBar1: TToolBar;
    ActionCreate: TAction;
    ToolButton1: TToolButton;
    ToolButton2: TToolButton;
    ToolButton3: TToolButton;
    ToolButton4: TToolButton;
    ToolButton5: TToolButton;
    ToolButton9: TToolButton;
    ActionOpen: TAction;
    ActionSave: TAction;
    ActionSaveAs: TAction;
    ActionClose: TAction;
    ActionBackground: TAction;
    MainSG: TStringGrid;
    FontDialog: TFontDialog;
    ColorDialog: TColorDialog;
    SaveDialog: TSaveDialog;
    OpenDialog: TOpenDialog;
    ToolButton6: TToolButton;
    ToolButton7: TToolButton;
    ToolButton8: TToolButton;
    N1: TMenuItem;
    N2: TMenuItem;
    StatusBar: TStatusBar;
    procedure ActionAddExecute(Sender: TObject);
    procedure ActionInfoExecute(Sender: TObject);
    procedure ActionFindExecute(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure CloseClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure ActionCloseExecute(Sender: TObject);
    procedure ActionCreateExecute(Sender: TObject);
    Procedure Show(First: pItem);
  //  procedure Button1Click(Sender: TObject);
    Procedure Refresher(First: pItem; NeedRefresh: Boolean);
    procedure ActionSaveExecute(Sender: TObject);
    Procedure Saving(First: pItem; Name: string);
    procedure ActionOpenExecute(Sender: TObject);
    Procedure OpenFile(var First: pItem; Name: string);
    Procedure Del(var First: pItem; Curr: pItem);
    procedure ActionDeleteExecute(Sender: TObject);
    Procedure ClearTable;
    procedure ActionEditExecute(Sender: TObject);
    procedure ActionDiagrammExecute(Sender: TObject);
    procedure ActionFontExecute(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure ActionBackgroundExecute(Sender: TObject);
    procedure ActionPrintExecute(Sender: TObject);
    procedure ActionSaveAsExecute(Sender: TObject);
    procedure ActionFontDecExecute(Sender: TObject);
    procedure ActionFontIncExecute(Sender: TObject);
  //  procedure ActionShowExecute(Sender: TObject);

   // Динамический список









  private
    { Private declarations }


  public
    { Public declarations }
  end;

var
  MainForm: TMainForm;   CanClose: Boolean;    NeedRefresh: Boolean;
  fName: string;
 // x: tData;
implementation

{$R *.dfm}

uses FDataCreate;

procedure TMainForm.ClearTable;
var i:word;
begin
with MainSG do
  for i:=0 to ColCount-1 do
    Cols[i].Clear;
end;

Procedure TMainForm.Refresher(First: pItem; NeedRefresh: Boolean);
var i,j: word; RowCount: pItem;
begin
if NeedRefresh=True then begin
 ClearTable;
 MainSG.Cells[0,0]:=('Номер');
MainSG.Cells[1,0]:=('Тип');
MainSG.Cells[2,0]:=('Наименование');
MainSG.Cells[3,0]:=('Кол-во з/е');
MainSG.Cells[4,0]:=('Оценка');
MainSG.Cells[5,0]:=('Дата');
MainSG.Cells[6,0]:=('Преподаватель');
MainSG.Cells[7,0]:=('Семестр');
 RowCount:=First;
 while RowCount<>Nil do begin
if RowCount^.Data.Number>MainSG.RowCount then
              MainSG.RowCount:=MainSG.RowCount+1;
        RowCount:=RowCount^.Next;
 end;
 {while First^.Next<>Nil do
 First:=First^.Next;
if MainSG.Row<First^.Data.Number then
MainSG.RowCount:=MainSG.RowCount+(First^.Data.Number-MainSG.RowCount);}
    j:=1;
  if First<>Nil then begin
while First<>Nil do begin
           MainSG.Cells[0,j]:=IntToStr(First^.Data.Number);
              MainSG.Cells[1,j]:=First.Data.SubType;
              MainSG.Cells[2,j]:=First.Data.subject;
              MainSG.Cells[3,j]:=First.Data.Count;
              MainSG.Cells[4,j]:=First.Data.mark;
              MainSG.Cells[5,j]:=DateToStr(First.Data.Date);
              MainSG.Cells[6,j]:=First.Data.surname;
              MainSG.Cells[7,j]:=IntToStr(First.Data.semester);
              inc(j);
              First:=First^.Next;
              //if First^.Next = Nil then

end;

end;
end;

end;
{
Function TMainForm.ListFind(First: pItem; x: tData): pItem;
begin
  while ((First^.Data<>x) and (First<>Nil)) do
                                        First:=First^.Next;
                                        ListFind:=First;
end; }
procedure TMainForm.ActionCreateExecute(Sender: TObject);
begin
 CreateForm.ShowModal;
  NeedRefresh:= True;
  Refresher(First, NeedRefresh);
end;

procedure TMainForm.ActionAddExecute(Sender: TObject);
begin
if First <>Nil then
begin
AddForm.ShowModal;
NeedRefresh:= True;
Refresher(First,NeedRefresh);
end
else
ActionCreateExecute(Sender);
end;




Procedure TMainForm.Del(var First: pItem; Curr: pItem);
var Pred: pItem; Purpose: pItem;
begin
if Curr=First then
begin
First:=Curr^.Next;
Dispose(Curr);
end
else begin
Pred:= First;
while Pred^.Next<>Curr do
Pred:=Pred^.Next;
Pred^.Next:=Curr^.Next;
Dispose(Curr);
ShowMessage('Элемент удален');
end;
end;

procedure TMainForm.ActionDeleteExecute(Sender: TObject);

var i:word;
begin
if MessageDlg('Вы действительно хотите удалить запись?',
mtConfirmation,[mbYes,mbNO],0)= mrYes
then begin
i:=MainSG.Row;
if StrToInt(MainSG.Cells[0,i])>0 then
 begin
Curr:=First;
while (Curr^.Data.Number<>StrToInt(MainSG.Cells[0,i])) do
Curr:=Curr^.Next;
Del(First, Curr);
NeedRefresh:=True;
 end;
 Refresher(First, NeedRefresh);
end
else exit;
end;

procedure TMainForm.ActionDiagrammExecute(Sender: TObject);
begin
GraphicForm.ShowModal;
end;

procedure TMainForm.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
if MessageDlg('Вы действительно хотите завершить работу программы?',
mtConfirmation,[mbYes,mbNO],0)<> mrYes
then CanClose:=False;
end;



procedure TMainForm.ActionCloseExecute(Sender: TObject);
begin
if MessageDlg('Вы действительно хотите завершить работу программы?',
mtConfirmation,[mbYes,mbNO],0)= mrYes
then
Application.Terminate;
end;

procedure TMainForm.CloseClick(Sender: TObject);
begin
if MessageDlg('Вы действительно хотите завершить работу программы?',
mtConfirmation,[mbYes,mbNO],0)= mrYes
then
Application.Terminate;
end;

Procedure TMainForm.Show(First: pItem);
var i,j: word;
begin
    j:=1;
  if First<>Nil then begin
while First<>Nil do begin
              MainSG.Cells[0,j]:=IntToStr(First^.Data.Number);
              MainSG.Cells[1,j]:=First.Data.SubType;
              MainSG.Cells[2,j]:=First.Data.subject;
              MainSG.Cells[3,j]:=First.Data.Count;
              MainSG.Cells[4,j]:=First.Data.mark;
              MainSG.Cells[5,j]:=DateToStr(First.Data.Date);
              MainSG.Cells[6,j]:=First.Data.surname;
              MainSG.Cells[7,j]:=IntToStr(First.Data.semester);
              inc(j);
              First:=First^.Next;
end;
end
else
showMessage('Список пуст');
end;

procedure TMainForm.ActionEditExecute(Sender: TObject);
var i: word;
begin
//New(Trigger);
Trigger:=First;
i:=MainSG.Row;
while (Trigger^.Data.Number<>StrToInt(MainSG.Cells[0,i])) do
Trigger:= Trigger^.Next;
EditForm.ShowModal;
NeedRefresh:=True;
Refresher(First,NeedRefresh);
//Dispose(Trigger);
end;

procedure TMainForm.ActionFindExecute(Sender: TObject);
begin
FindForm.ShowModal;
end;

procedure TMainForm.ActionFontDecExecute(Sender: TObject);
begin
if MainSG.Font.Size>8 then
MainSG.Font.Size:=MainSG.Font.Size-1;
end;

procedure TMainForm.ActionFontExecute(Sender: TObject);
begin
//FontDialog.Execute;
if FontDialog.Execute then
MainSG.Font:=FontDialog.Font;
end;

procedure TMainForm.ActionFontIncExecute(Sender: TObject);
begin
if MainSG.Font.Size<16 then
MainSG.Font.Size:=MainSG.Font.Size+1;
end;

procedure TMainForm.ActionBackgroundExecute(Sender: TObject);
begin
if ColorDialog.Execute then
Self.Color:=ColorDialog.Color;
end;

procedure TMainForm.ActionInfoExecute(Sender: TObject);
begin
AboutForm.Show;
end;

Procedure TMainForm.OpenFile(var First: pITem; Name: string);
var F: File of tdata; i:integer; s:tdata;  last,  k: pITem;
begin
New(k);
AssignFile(F, Name);
{$I-}Reset(F);{$I+}
If ioresult<>0 then begin ShowMessage('Файл не найден');
exit;
end else begin
read(F,s);
k^.data:=s;
k^.next:=first;
first:=k;
while not (eof(f)) do begin
Read(F, s);
AddForm.AddLast(First, s);
end;
CloseFile(F);
end;
end;

procedure TMainForm.ActionOpenExecute(Sender: TObject);
var Name: string;
begin
ClearTable;
MainSG.Cells[0,0]:=('Номер');
MainSG.Cells[1,0]:=('Тип');
MainSG.Cells[2,0]:=('Наименование');
MainSG.Cells[3,0]:=('Кол-во з/е');
MainSG.Cells[4,0]:=('Оценка');
MainSG.Cells[5,0]:=('Дата');
MainSG.Cells[6,0]:=('Преподаватель');
MainSG.Cells[7,0]:=('Семестр');
First:=Nil;
OpenDialog.Execute;
Name:= OpenDialog.FileName;
       Statusbar.Panels.Items[0].Text:=OpenDialog.FileName;
OpenFile(First, name);
MainForm.Caption:=Name;
Show(First);
end;

procedure TMainForm.ActionPrintExecute(Sender: TObject);
begin

end;

// Сохранение
Procedure TMAinForm.Saving(First: pItem; Name: string);
var F: file of tdata;
begin
AssignFile(F, Name);
Rewrite(F);
While First<>nil do begin
write(F, First^.data);
First:=First^.next;
end;
CloseFile(F);
end;

procedure TMainForm.ActionSaveAsExecute(Sender: TObject);
var Name: string;
begin
if SaveDialog.Execute then begin
Name:= SaveDialog.FileName;
Saving(First, name);
MainForm.Caption:= Name;
end;
end;

procedure TMainForm.ActionSaveExecute(Sender: TObject);
var Name: string;
begin
if MainForm.Caption = 'MainForm' then
ActionSaveAsExecute(Sender)
else begin
//SaveDialog.Execute;
Name:= MainForm.Caption;
Saving(First, name);
end;
end;

{// procedure TMainForm.ActionShowExecute(Sender: TObject);
begin

end;

BUTTON
procedure TMainForm.Button1Click(Sender: TObject);
begin
  Show(First);
end;    }



procedure TMainForm.FormCreate(Sender: TObject);
var
   settings: TIniFile;
begin
Settings:=TiniFile.Create(extractfilepath(paramstr(0))+'Settings.ini');
  MainSG.Font.Color:=settings.Readinteger('Font','Color',0);
  MainSG.Font.Name:= Settings.ReadString('Font','Name','Tahoma');
  MainSG.Font.Size:= Settings.ReadInteger('Font','Size',8);

  Self.Color:=Settings.ReadInteger('BackGround','Color',0);
  if Settings.ReadInteger('Font','Bold',0)=1 then
    MainSG.Font.Style:=[fsBold];
  if Settings.ReadInteger('Font','Italic',0)=1 then
    MainSG.Font.Style:=[fsItalic];
  if Settings.ReadInteger('Font','BoldItalic',0)=1 then
   MainSG.Font.Style:=[fsBold, fsItalic];

   if Settings.ReadInteger('BackGround','Color',0)=1 then
     Self.Color:=clWhite;


  Settings.Free;

MainSG.Cells[0,0]:=('Номер');
MainSG.Cells[1,0]:=('Тип');
MainSG.Cells[2,0]:=('Наименование');
MainSG.Cells[3,0]:=('Кол-во з/е');
MainSG.Cells[4,0]:=('Оценка');
MainSG.Cells[5,0]:=('Дата');
MainSG.Cells[6,0]:=('Преподаватель');
MainSG.Cells[7,0]:=('Семестр');
NeedRefresh:=False;

end;




procedure TMainForm.FormDestroy(Sender: TObject);
var
   settings: TIniFile;
begin

     Settings:=TiniFile.Create(extractfilepath(paramstr(0))+'Settings.ini');
  Settings.WriteString('Font','Name',MainSG.Font.Name);
  Settings.WriteInteger('Font','Size',MainSG.Font.Size);
  settings.Writeinteger('Font','Color',MainSG.Font.Color);

  Settings.WriteInteger('BackGround','Color',Self.Color);
  if MainSG.Font.Style=[fsBold] then
    Settings.WriteInteger('Font','Bold',1)
  else
    Settings.WriteInteger('Font','Bold',0);

    if Self.Color=clWhite then
    Settings.WriteInteger('BackGround','Color',$FFFFFF)
    else
    Settings.WriteInteger('BackGround','Color',Self.Color);

  if MainSG.Font.Style=[fsItalic] then
    Settings.WriteInteger('Font','Italic',1)
  else
    Settings.WriteInteger('Font','Italic',0);
  if MainSG.Font.Style=[fsBold, fsItalic] then
    Settings.WriteInteger('Font','BoldItalic',1)
  else
    Settings.WriteInteger('Font','BoldItalic',0);
  Settings.Free;
end;

end.
