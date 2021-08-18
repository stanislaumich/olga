program Project138;
{138 Дано: Х1=[2,4,6,8,10]; Х2=[1,3,5..7].X3=[4,9,10]
Напишите программу, которая формирует множество Y=(Xl+X2+ХЗ)
и выделите из него подмножество Y1,
которое представляет все цифры, входящие в Y. }
{$APPTYPE CONSOLE}
{$R *.res}
uses
  System.SysUtils;
Const{Задаем множества}
 X1:set of byte=[2,4,6,8,10];
 X2:set of byte=[1,3,5,7];
 X3:set of byte=[4,9,10];
var
 Y1,Y:set of byte;
 i,n:byte;
begin
 Y :=X1+X2+X3;{Вычисляем Y1}
 Writeln('Множество Y1=');
 for I := 1 to 30 do{Заполняем Y1 элементами }
  if i in Y then
   begin
    Include(Y1,i);{Включаем элемент в Y1  }
    Write(i,'  ');{Выводим элемент }
   End;
 WriteLn;
 WriteLn('Нажмите Enter');
 ReadLn;
end.

