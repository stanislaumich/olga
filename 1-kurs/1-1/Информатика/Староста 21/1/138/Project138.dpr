program Project138;
{138 ����: �1=[2,4,6,8,10]; �2=[1,3,5..7].X3=[4,9,10]
�������� ���������, ������� ��������� ��������� Y=(Xl+X2+��)
� �������� �� ���� ������������ Y1,
������� ������������ ��� �����, �������� � Y. }
{$APPTYPE CONSOLE}
{$R *.res}
uses
  System.SysUtils;
Const{������ ���������}
 X1:set of byte=[2,4,6,8,10];
 X2:set of byte=[1,3,5,7];
 X3:set of byte=[4,9,10];
var
 Y1,Y:set of byte;
 i,n:byte;
begin
 Y :=X1+X2+X3;{��������� Y1}
 Writeln('��������� Y1=');
 for I := 1 to 30 do{��������� Y1 ���������� }
  if i in Y then
   begin
    Include(Y1,i);{�������� ������� � Y1  }
    Write(i,'  ');{������� ������� }
   End;
 WriteLn;
 WriteLn('������� Enter');
 ReadLn;
end.

