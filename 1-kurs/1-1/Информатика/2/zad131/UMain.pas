unit UMain;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Button1: TButton;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    N2: TMenuItem;
    N3: TMenuItem;
    N4: TMenuItem;
    Button2: TButton;
    procedure N4Click(Sender: TObject);
    procedure N2Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  N:integer;
  S:string;
implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var
 i:integer;
 c:char;
begin
N:=0;{������� ���������� ������}
{�������� ������� ������ �� ������� ��������
}
Label3.Caption:='��������� ���� �� ����������';
if Edit1.Text='' then
 begin  {�� ������� ����� ��� ������}
 ShowMessage('�� ������� ����� ��� ������');
 exit;
 end;
if length(Edit1.Text)>1 then
 begin {������� ����� ����� �����}
 ShowMessage('������� ����� ��� ���� ����� ��� ������');
 exit;
 end;
if Edit2.Text='' then
 begin   {������� ������ ������ ��� ������}
 ShowMessage('�� ������� ������ ��� ������');
 exit;
 end;
 S:=Edit2.Text;{��������� ��� �����}
 for i := 1 to length(s) do
  if edit1.text=s[i] then
   inc(n);
 {������� ���������}
 Label3.Caption:='��������� ������, ������� �������:'+inttostr(N);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
 Application.Terminate;
end;

procedure TForm1.N2Click(Sender: TObject);
begin
 Button1.Click;
end;

procedure TForm1.N4Click(Sender: TObject);
begin
Application.Terminate;
end;

end.
