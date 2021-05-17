unit FGraphic;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, VclTee.TeeGDIPlus, VCLTee.TeEngine,
  VCLTee.Series, Vcl.ExtCtrls, VCLTee.TeeProcs, VCLTee.Chart, DynamicList;

type
  TGraphicForm = class(TForm)
    Chart1: TChart;
    Series1: TPieSeries;
    Procedure DataLoad(First: pItem; var i,j,k: word);
    procedure FormShow(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  GraphicForm: TGraphicForm; i,j,k: word;

implementation

{$R *.dfm}
Procedure TGraphicForm.DataLoad(First: pItem; var i,j,k: word);
begin
  i:=0; j:=0; k:=0;
while First<>Nil do begin
if First^.Data.mark='�������' then
inc(i);
if First^.Data.mark = '������' then
inc(j);
if First^.Data.mark = '�����������������' then
inc(k);
//ShowMessage(IntToStr(k));
First:=First^.Next;
end;
end;

procedure TGraphicForm.FormShow(Sender: TObject);
begin
Series1.Clear;
DataLoad(First,i,j,k);
Series1.Add(i,'�������', clYellow);
Series1.Add(j,'������',clRed);
Series1.Add(k,'�����������������',clBlue);
//end;
end;

end.
