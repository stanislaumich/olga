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
N:=0;{обнулим переменную поиска}
{проверим входные данные на наличие символов
}
Label3.Caption:='Результат пока не вычислялся';
if Edit1.Text='' then
 begin  {Не указано буквы для поиска}
 ShowMessage('Не указана буква для поиска');
 exit;
 end;
if length(Edit1.Text)>1 then
 begin {Указано более одной буквы}
 ShowMessage('Указано более чем одна буква для поиска');
 exit;
 end;
if Edit2.Text='' then
 begin   {Указана пустая строка для поиска}
 ShowMessage('Не указана строка для поиска');
 exit;
 end;
 S:=Edit2.Text;{Реализуем сам поиск}
 for i := 1 to length(s) do
  if edit1.text=s[i] then
   inc(n);
 {Выводим результат}
 Label3.Caption:='Результат поиска, найдено позиций:'+inttostr(N);
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
