
program Gauss;
{��⮤ �����}
uses crt;
Const
     n = 3;
Type
	Data = array [0..n,0..n+1] of extended;
var
    i,j,l,k,p:integer;
    c: extended;
    FT:TEXT;
procedure ShowMatrix;
var
	is1,js: integer;
begin
    Writeln;
    for is1:=0 to n do {for column} begin
    for js:=0 to n1 do begin {for rows}
        if A[is1] > 0 then
        begin
	Write('�',A[is1,js]:7:4);
    Write(FT,'�',A[is1,js]:7:4)
	end
        else
        begin
        Write('�',A[is1,js]:7:3);
        Write(FT,'�',A[is1,js]:7:3);
        end;
    end;
    Writeln('�');
    end;
    Writeln;
    Writeln('    Press Enter for continue...');
    Readln;
end;

begin
	ClrScr;
    Assign(FT,'c:\Gauss.txt');
    ReWrite(FT);

    Writeln('  The result is:');
    Writeln;
    for i:=0 to n do 
    begin
    Writeln('  x',i,' = ',A[i,n+1]:7:4);
    Writeln(FT,'  x',i,' = ',A[i,n+1]:7:4);
    end;
    ShowMatrix;
    Close(FT);
end.