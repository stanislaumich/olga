unit FDataEdit;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, DynamicList;

type
  TEditForm = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Edit1: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Button1: TButton;
    Edit2: TEdit;
    Procedure LoadList(First: pItem);
    procedure Button1Click(Sender: TObject);
 //   procedure FormCreate(Sender: TObject);

    Procedure EditList(First: pItem);
    procedure FormShow(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  EditForm: TEditForm;

implementation
uses StudentBook;
{$R *.dfm}



Procedure TEditForm.LoadList(First: pItem);
begin
 while (First^.Data.Number<>Trigger^.Data.Number ) do
First:=First^.Next;
Edit1.Text:=First^.Data.SubType;
Edit2.Text:=First^.Data.subject;
Edit3.Text:=First^.Data.Count;
Edit4.Text:=First^.Data.mark;
Edit5.Text:=DateToStr(First^.Data.Date);
Edit6.Text:=First^.Data.surname;
Edit7.Text:=IntToStr(First^.Data.semester);
end;

Procedure TEditForm.EditList(First: pItem);
begin
while (First^.Data.Number<>Trigger^.Data.Number ) do
First:=First^.Next;
First^.Data.SubType:=Edit1.Text;
First^.Data.subject:=Edit2.Text;
First^.Data.Count:=Edit3.Text;
First^.Data.mark:=Edit4.Text;
First^.Data.Date:=StrToDate(Edit5.Text);
First^.Data.surname:=Edit6.Text;
First^.Data.semester:=StrToInt(Edit7.Text);
end;

procedure TEditForm.FormShow(Sender: TObject);
begin
LoadList(First);
end;

{procedure TEditForm.FormCreate(Sender: TObject);
begin
 EditList(First);
end;     }

procedure TEditForm.Button1Click(Sender: TObject);
begin
  EditList(First);
  Self.Close;
 { Edit1.Clear;
  Edit2.Clear;
  Edit3.Clear;
  Edit4.Clear;
  Edit5.Clear;
  Edit6.Clear;
  Edit7.Clear;  }
  //Dispose(Trigger);
end;
end.
