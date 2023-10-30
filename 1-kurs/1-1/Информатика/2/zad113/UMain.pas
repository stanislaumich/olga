unit UMain;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.ExtCtrls, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Image1: TImage;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    Button1: TButton;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    N2: TMenuItem;
    N3: TMenuItem;
    N4: TMenuItem;
    N5: TMenuItem;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure RadioButton1Click(Sender: TObject);
    procedure RadioButton2Click(Sender: TObject);
    procedure N5Click(Sender: TObject);
    procedure N2Click(Sender: TObject);
    procedure N3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  Rect:TRect;
  D:cardinal;
implementation

{$R *.dfm}
{
�� ����� ���������� Image ��� ������� ������ ����������
��������� ����������� ���������. ������������ ���������
�� ������. ��� ������ ����������� RadioButton ��������
������ ������ ����������� � ���������, ����������.
��� ���������� ������������ ��������� Timer. ���������
�������, �������, ���� ����������, ������ �� �������������
����� ������. ����� ����������� ������ ��������� ������
��� �������� ����������, ������ ������� ����������� �
������� ����, ����������� �������� ��������.
}
procedure Delay(Value: Cardinal);
var
  F, N: Cardinal;
begin
  N := 0;
  while N <= (Value div 10) do
  begin
    SleepEx(1, True);
    Application.ProcessMessages;
    Inc(N);
  end;
  F := GetTickCount;
  repeat
    Application.ProcessMessages;
    N := GetTickCount;
  until (N - F >= (Value mod 10)) or (N < F);
end;

procedure TForm1.Button1Click(Sender: TObject);
begin

 Image1.Canvas.FillRect(Rect);{������� ���������}
 with Image1.Canvas do
  begin
   MoveTo(50, 250);
   LineTo(Image1.Width-50, 250);
   delay(D);
   LineTo(Image1.Width-5, 210);
   delay(D);
   LineTo(5, 210);
   delay(D);
   LineTo(50, 250);
   delay(D);
   MoveTo(150, 210);
   LineTo(150, 20);
   delay(D);
   LineTo(170, 30);
   delay(D);
   LineTo(150, 40);
   delay(D);
   MoveTo(150,20);
   LineTo(30, 190);
   delay(D);
   LineTo(Image1.Width-35,190);
   delay(D);
   LineTo(150, 40);
 end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
Rect.Left:=0;
Rect.Top:=0;
Rect.Right:=Image1.Width;
Rect.Bottom:=Image1.Height;
D:=0;
end;



procedure TForm1.N2Click(Sender: TObject);
begin
 Form1.RadioButton1.Checked:=true;
 D:=0;
 Button1.Click;
end;

procedure TForm1.N3Click(Sender: TObject);
begin
 Form1.RadioButton2.Checked:=true;
 D:=1000;
 Button1.Click;
end;

procedure TForm1.N5Click(Sender: TObject);
begin
 Application.Terminate;
end;

procedure TForm1.RadioButton1Click(Sender: TObject);
begin
 D:=0;
end;

procedure TForm1.RadioButton2Click(Sender: TObject);
begin
D:=1000;
end;

end.
