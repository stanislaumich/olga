unit UMain;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.ExtCtrls, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Image1: TImage;
    Timer1: TTimer;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    Button1: TButton;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

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
end.
