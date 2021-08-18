program Romanian91;

var
  s: string;
  tI, tX: byte;
  f: byte;
  res: integer;

begin
  repeat
    WriteLn('Введите Z для окончания ввода');
    Write('Введите число: ');
    ReadLn(s);
    tI := 0;
    tX := 0;
    res := 0;
    // считаем сумму всех встретившихся
    // римских чисел согласно их значениям
    for f := 1 to length(s) do
    begin
      case s[f] of
        'I': inc(res, 1);
        'V': inc(res, 5);
        'X': inc(res, 10);
        'L': inc(res, 50);
        'C': inc(res, 100);
      end;
      // res - общая сумма чисел, но нужно обработать комбинации
      // вида I перед X или V
      if (s[f] = 'V') and (tI <> 0) then
      begin// ситуация когда I перед V
        tX := 0;
        res := res - 2 * tI;//удваиваем потому что уже первый раз прибавили к
                            // общей сумме а второй как действие модификатора
        tI := 0;
        continue// переходим к следующей итерации цикла без остальных
                //проверок
      end;
      if (s[f] = 'X') and (tI <> 0) then
      begin// ситуация когда I перед X
        res := res - 2 * tI;
        tI := 0;
        tX := 0;
        continue
      end;
      // нужно обработать комбинации
      // вида X перед L или C
      if (s[f] = 'L') and (tX <> 0) then
      begin// ситуация когда X перед L
        res := res - tX * 20;
        tX := 0;
        continue
      end;
      if (s[f] = 'C') and (tX <> 0) then
      begin// ситуация когда X перед C
        res := res - tX * 20;
        tX := 0;
        continue
      end;
      // запоминаем количество I и X вдруг они потом
      // станут модификаторами для X L C V
      if s[f] = 'I' then
      begin
        inc(tI);// считаем количество I вдруг потом будет V или X
        continue
      end;
      if s[f] = 'X' then
      begin
        inc(tX);// считаем количество X вдруг потом будет C или L
        continue
      end
    end;
    WriteLn('Ответ -> ', res);
  until (s = 'Z') or (s = 'z')// в любом регистре

end.

