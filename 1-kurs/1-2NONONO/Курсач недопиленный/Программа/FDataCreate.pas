unit FDataCreate;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, DynamicList;

type
{tData= record
Number: byte;
SubType: string[15];
subject: string[20];
Count: string[10];
mark: string[15];
Date: TDateTime;
surname: string[20];
semester: byte;
end; }
  TCreateForm = class(TForm)
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

   Procedure ListInit(var First: pItem);
   Procedure AddFirst(var First: pItem; x: tData);
   Procedure Reading(var x: tData);
   procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public

    { Public declarations }
  end;

var
 CreateForm: TCreateForm; x: tData;//DList: TDList;   //First: pItem;

implementation

{$R *.dfm}

Procedure TCreateForm.ListInit(var First: pItem);
begin
  First := Nil;
end;

Procedure TCReateForm.AddFirst(var First: pItem; x: tData);
var N: pItem;
begin
New(N); N^.Data:=x;
N^.Next:=First;
First:=N;
end;

Procedure TCreateForm.Reading(var x: tData);
begin
  x.Number := 1;
  x.SubType := Combobox1.Text;
  x.subject := Edit2.Text;
  x.Count := Edit3.Text;
  x.mark := Edit4.Text;
  x.Date := StrToDate(Edit5.Text);
  x.surname := Edit6.Text;
  x.semester := StrToInt(Edit7.Text);
end;



procedure TCreateForm.Button1Click(Sender: TObject);
begin
if First<> Nil then begin
if MessageDlg('������ ��� ������, ��� �������� ������ ������ ������ ������ �� ����������. �� ������������� ������ ������� ����� ������?',
mtConfirmation,[mbYes,mbNO],0)= mrYes
then begin
  ListInit(First);
  Reading(x);
  AddFirst(First,x);
  Self.Close;
  end
  else
  Self.Close;
end
else begin
ListInit(First);
Reading(x);
AddFirst(First,x);
Self.Close;
end;
end;

end.
