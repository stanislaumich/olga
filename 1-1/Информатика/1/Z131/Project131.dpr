program Project131;
{$APPTYPE CONSOLE}
{$R *.res}
uses
  System.SysUtils;
const
 X1:set of byte=[1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20];
 X2:set of byte=[10,20,30];
 X3:set of byte=[1,3,5,7,9,11,13,15,17,19,21];
var
 Y1,Y:set of byte;
 i,n:byte;
begin
 Y :=(X1*X2)+(X1*X3)+(X2*X3);
 Writeln('��������� Y=');
 for I := 1 to 30 do
  if I in Y then
    Write(I,'   ');
 Writeln('');

 for I := 1 to 30 do
  if (I in Y)and(I mod 9 = 0) then
    Include(Y,i);

 N:=0;
 for I := 1 to 30 do
  if I in Y1 then
    N:=N+1;

 WriteLn('�������� ��������� Y1=',N);
 WriteLn('������� Enter');
 ReadLn;
end.
