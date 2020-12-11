program Project138;
{138 Дано: Х1=[2,4,6,8,10]; Х2=[1,3,5..7].-
Напишите программу, которая формирует множество Y=(Xl+X2+ХЗ)
и выделите из него подмножество Y1,
которое представляет все цифры, входящие в Y. }
{$APPTYPE CONSOLE}
{$R *.res}
uses
  System.SysUtils;
const
 X1:set of byte=[2,4,6,8,10];
 X2:set of byte=[1,3,5,7];
var
 Y,Y1:set of byte;
 i,t:byte;
begin
 Y:=X1+X2;
 Write('Y1=');
 for I := 1 to 30 do
    begin
     if (i in Y) then
      begin
       Include(Y,i);
       Write(i,'   ');
      end;
    end;
  WriteLn('');
  WriteLn('Нажмите Ввод');
  ReadLn;
end.
