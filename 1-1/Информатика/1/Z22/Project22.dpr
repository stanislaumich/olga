program Project22;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;
var
 N,Npos,Notr:integer;
 Ncurotr,Ncurpos:integer;
 i:integer;
 A:array[1..100] of integer;
begin
  Write('������� ���-�� ��������� �������: ');
  ReadLn(N);
  Ncurpos:=1;
  Ncurotr:=1;
  for I := 1 to N do
     begin
      Write('������� A[',i,']: ');
      ReadLn(A[i]);
     end;
  for I:= 1 to n-1 do
     begin
      if (A[i]>0) and (A[i+1]>0) then inc(Ncurpos)
       else Ncurpos:=1;
      if (A[i]<0) and (A[i+1]<0) then inc(Ncurotr)
       else Ncurotr:=1;
      if Ncurpos>Npos then Npos:=Ncurpos;
      if Ncurotr>Notr then Notr:=Ncurotr;
     end;
  Writeln('����������� ������ ������������� ���������: ',Npos);
  Writeln('����������� ������ ������������� ���������: ',Notr);
  Writeln('������� Enter');
  Readln;
  Readln;
end.
