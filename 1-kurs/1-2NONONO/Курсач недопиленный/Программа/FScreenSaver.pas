unit FScreenSaver;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtCtrls, Vcl.Imaging.jpeg;

type
  TScreenSaverForm = class(TForm)
    Timer1: TTimer;
    Image1: TImage;
    procedure Timer1Timer(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  ScreenSaverForm: TScreenSaverForm;

implementation

{$R *.dfm}



procedure TScreenSaverForm.Timer1Timer(Sender: TObject);
begin
Timer1.Enabled:=False;
Close;
end;

end.
