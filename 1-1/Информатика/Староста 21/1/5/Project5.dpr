program Project5;
{$APPTYPE CONSOLE}
{$R *.res}
uses
  System.SysUtils;

var
 N: integer;
 i : integer;
 A:array[1..100] of integer;
begin
  Write('������� ���-�� ��������� �������: ');
  ReadLn(N);
A[1]:=1;
A[2]:=2;
  for i := 3 to N do {��������� ���������� �������� �������}
     begin
      A[i]:=A[i-1]+A[i-2];
     end;
  for i:= 1 to N do{�� ���� ��������� ������� ������� �� �����}
     begin
      Write(A[i],'    ');
     end;
  WriteLn;
  Writeln('������� ����');
  Readln;
end.

