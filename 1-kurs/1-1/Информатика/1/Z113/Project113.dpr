program Project113;
{ВНИМАНИЕ - обрабатывает Английскую раскладку}
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;
const
 A:set of char = ['a','b','c','d','e','f','g','h','i',
                  'j','k','l','m','n','o','p','q',
                  'r','s','t','u','v','w','x','y','z'];
var
 sin:string;
 i,n:integer;
begin
 Write('Введите строку: ');
 ReadLn(sin);
 for I := 1 to length(sin) do
  begin
   if sin[i] in A then
    begin
     n:=n+1;
     sin[i]:=upcase(sin[i]);
    end;
  end;
 Writeln('Результирующая строка: ',sin);
 Writeln('Количество замен: ',n);
 WriteLn('Нажмите Enter');
 ReadLn;
end.
