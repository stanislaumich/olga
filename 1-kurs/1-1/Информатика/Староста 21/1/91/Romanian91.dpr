program Romanian91;

var
  s: string;
  tI, tX: byte;
  f: byte;
  res: integer;

begin
  repeat
    WriteLn('������� Z ��� ��������� �����');
    Write('������� �����: ');
    ReadLn(s);
    tI := 0;
    tX := 0;
    res := 0;
    // ������� ����� ���� �������������
    // ������� ����� �������� �� ���������
    for f := 1 to length(s) do
    begin
      case s[f] of
        'I': inc(res, 1);
        'V': inc(res, 5);
        'X': inc(res, 10);
        'L': inc(res, 50);
        'C': inc(res, 100);
      end;
      // res - ����� ����� �����, �� ����� ���������� ����������
      // ���� I ����� X ��� V
      if (s[f] = 'V') and (tI <> 0) then
      begin// �������� ����� I ����� V
        tX := 0;
        res := res - 2 * tI;//��������� ������ ��� ��� ������ ��� ��������� �
                            // ����� ����� � ������ ��� �������� ������������
        tI := 0;
        continue// ��������� � ��������� �������� ����� ��� ���������
                //��������
      end;
      if (s[f] = 'X') and (tI <> 0) then
      begin// �������� ����� I ����� X
        res := res - 2 * tI;
        tI := 0;
        tX := 0;
        continue
      end;
      // ����� ���������� ����������
      // ���� X ����� L ��� C
      if (s[f] = 'L') and (tX <> 0) then
      begin// �������� ����� X ����� L
        res := res - tX * 20;
        tX := 0;
        continue
      end;
      if (s[f] = 'C') and (tX <> 0) then
      begin// �������� ����� X ����� C
        res := res - tX * 20;
        tX := 0;
        continue
      end;
      // ���������� ���������� I � X ����� ��� �����
      // ������ �������������� ��� X L C V
      if s[f] = 'I' then
      begin
        inc(tI);// ������� ���������� I ����� ����� ����� V ��� X
        continue
      end;
      if s[f] = 'X' then
      begin
        inc(tX);// ������� ���������� X ����� ����� ����� C ��� L
        continue
      end
    end;
    WriteLn('����� -> ', res);
  until (s = 'Z') or (s = 'z')// � ����� ��������

end.

