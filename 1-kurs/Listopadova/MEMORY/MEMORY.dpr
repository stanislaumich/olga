program MEMORY;

uses
  Vcl.Forms,
  Windows,
  Messages,
  Dialogs,
  UMain in 'UMain.pas' {Form1},
  Vcl.Themes,
  Vcl.Styles,
  Unit2 in 'Unit2.pas' {Form2},
  ABOUT in 'ABOUT.pas' {AboutBox};

{$R *.res}

begin
 if FindWindow('TForm1', 'Напоминалка') <> 0 then
  begin
    ShowWindow(FindWindow('TForm1', 'Напоминалка'),SW_restore);
    SetForegroundWindow(FindWindow('TForm1', 'Напоминалка'))
  end
  else
  begin
    Application.Initialize;
    Application.MainFormOnTaskbar := True;
    Application.Title := 'Напоминалка';
    Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TAboutBox, AboutBox);
  Application.Run;
 end;






end.
