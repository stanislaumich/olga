program DOVERENNOST;

uses
  Vcl.Forms,
  UMain in 'UMain.pas' {Form1},
  Ustr in '..\MYUNITS\Ustr.pas',
  ABOUT in 'ABOUT.pas' {AboutBox};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TAboutBox, AboutBox);
  Application.Run;
end.
