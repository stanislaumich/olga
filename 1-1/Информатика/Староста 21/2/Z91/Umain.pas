unit Umain;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    Label4: TLabel;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var
 Res:single;
begin
 if RadioButton1.Checked then
  begin {������� �������� �����}
   Res:=strtofloat(Edit1.Text)+strtofloat(Edit2.Text)+strtofloat(Edit3.Text);
   {������� ��������� �������� � Label4}
   Label4.Caption:='���������: '+Floattostr(Res);
  end;
 if RadioButton2.Checked then
  begin{������� ��������� �����}
   Res:=strtofloat(Edit1.Text)*strtofloat(Edit2.Text)*strtofloat(Edit3.Text);
   {������� ��������� �������� � Label4}
   Label4.Caption:='���������: '+Floattostr(Res);
  end;
end;

end.
