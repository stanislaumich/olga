unit FAddData;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Vcl.Grids,
  Vcl.StdCtrls, FDataCreate, DynamicList, DateUtils;

type
  TAddForm = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Button1: TButton;
    ComboBox1: TComboBox;

Function Reading(var x: tData):boolean;
Procedure AddLast(First: pItem; x: tData);
procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;



var
  AddForm: TAddForm; x: tData;//First: pItem; DList: TDList; //
   dates : array [1..12] of integer=(31,28,31,30,31,30,31,31,30,31,30,31);
   code:integer;
implementation

{$R *.dfm}

Procedure TAddForm.AddLast(First: pItem; x: tData);
var N: pItem; Last: pItem;
begin
 New(N);
 N^.Data:=x;
 N^.Next:=Nil;
 Last:=First;
 While(Last^.Next<>Nil) do
 Last:= Last^.Next;
 Last^.Next:=N;
 N^.Next:=nil;
end;

function pnext(del:string; var s:string):string;
var
ts:string;
begin
 ts:='';
 If pos(del,s)<>0 then
  begin
   ts:=s;
   delete(s,1,pos(del,s));
   delete(ts,pos(del,ts),length(ts));
  end;
 pnext:=ts;
end;

function validatedate(s:string):boolean;
var
 day,month,year:integer;
 begin
  Result:=true;
  dates[2]:=28;
  day:=strtoint(pnext('.',s));
  month:=strtoint(pnext('.',s));
  year:=strtoint(s);
  if (day<1) or(month<1) or (year<1) then
   begin
    result:=false;
    exit;
   end;
  if (year mod 4 = 0) then dates[2]:=29;
  if day>dates[month] then result:=false;
 end;



Function TAddForm.Reading(var x: tData):boolean;
var Last: pItem;f:boolean;
begin
f:=true;
Last:=First;
while Last^.Next<>Nil do
Last:=Last^.Next;
x.Number := Last^.Data.Number+1;

  x.SubType := Combobox1.Text;
  x.subject := Edit2.Text;
  x.Count := Edit3.Text;
  x.mark := Edit4.Text;
  //if not ValidateDate(Edit5.Text) then ShowMessage('Неправильно указана дата!');
  if not ValidateDate(Edit5.Text) then
   begin
     ShowMessage('Неправильно указана дата!');
    f:=false;

   end
   else
   x.Date := StrToDate(Edit5.Text);

  x.surname := Edit6.Text;

   val(Edit7.Text,num,code);
  if code=0 then
  x.semester := StrToInt(Edit7.Text) else
   begin
    Showmessage('Неверное числовое значение!!');
    f:=false;
   end;

  Reading:=f;
end;

procedure TAddForm.Button1Click(Sender: TObject);
begin
if Reading(x) then begin
AddLast(First,x);
Self.Close;
end;
end;
end.
