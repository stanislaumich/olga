program Project60;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

var
 Nkrat,Notr:integer;
 l,p:integer;
 i,j:integer;
 B:array[1..100,1..100] of integer;
begin
  Write('������� l: ');
  ReadLn(l);
  Write('������� p: ');
  ReadLn(p);
  Nkrat:=0;
  Notr:=0;
  for I := 1 to l do
     begin
      for J := 1 to p do
       begin
        Write('������� B[',i,',',j,']: ');
        ReadLn(B[i,j]);
        if (B[i,j] mod 3 = 0) then inc(Nkrat);
        if (B[i,j]<0) then inc(Notr);
       end;
      Writeln;
     end;
  Writeln('���������� ������� 3 ���������: ',Nkrat);
  Writeln('������������� ���������: ',Notr);
  Writeln('������� Enter');
  Readln;
  Readln;
end.

