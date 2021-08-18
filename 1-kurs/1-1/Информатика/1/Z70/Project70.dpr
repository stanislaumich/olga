program Project70;
{$APPTYPE CONSOLE}
{$R *.res}
uses
  System.SysUtils;
var
 c:int64;
 n,m:integer;
function fact(n:integer):int64;
 var
  i:integer;
  r:int64;
 begin
  r:=1;
  for i := 1 to n do
   r:=r*i;
  result:=r;
 end;

begin
 Write('Введите N: ');
 ReadLn(n);
 Write('Введите M: ');
 ReadLn(m);
 if N>M then
 begin

  c:=fact(n) div (fact(m)*(n-m));
  Writeln('С=',c);
 end
 else
  begin
   Writeln('Не выполнено условие - N>M');
  end;
  WriteLn('Нажмите Enter');
  ReadLn;
end.
