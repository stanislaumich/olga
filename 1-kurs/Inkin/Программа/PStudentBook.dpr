program PStudentBook;

uses
  Vcl.Forms,
  StudentBook in 'StudentBook.pas' {MainForm},
  FScreenSaver in 'FScreenSaver.pas' {ScreenSaverForm},
  FAbout in 'FAbout.pas' {AboutForm},
  FAddData in 'FAddData.pas' {AddForm},
  FDataFind in 'FDataFind.pas' {FindForm},
  FDataEdit in 'FDataEdit.pas' {EditForm},
  FDataCreate in 'FDataCreate.pas' {CreateForm},
  DynamicList in 'DynamicList.pas',
  FGraphic in 'FGraphic.pas' {GraphicForm};

{$R *.res}

begin
  Application.Initialize;
  ScreenSaverForm:=TScreenSaverForm.Create(Nil);
  ScreenSaverForm.ShowModal;
  ScreenSaverForm.Free;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TMainForm, MainForm);
  Application.CreateForm(TAboutForm, AboutForm);
  Application.CreateForm(TAddForm, AddForm);
  Application.CreateForm(TFindForm, FindForm);
  Application.CreateForm(TEditForm, EditForm);
  Application.CreateForm(TCreateForm, CreateForm);
  Application.CreateForm(TGraphicForm, GraphicForm);
  Application.Run;
end.
