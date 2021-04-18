unit DynamicList;
interface
uses
Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Vcl.Grids,
  Vcl.StdCtrls;
type
//������������ ������
tData= record
Number: byte;
SubType: string[50];
subject: string[50];
Count: string[10];
mark: string[30];
Date: TDateTime;
surname: string[30];
semester: byte;
end;
pItem=^tItem;
tItem=record
Data: tData;
Next: pItem;
end;

TDList = class(TObject)

//������
public
//Procedure ListInit(var First: pItem);
//Procedure AddFirst(var First: pItem; x: tData);
//Procedure AddLast(First: pItem; x: tData);
//Procedure Del(var First: pItem; Curr: pItem);
//  Procedure ListFind(First: pItem; x: tData);
end;

var First, Trigger, Curr: pItem;

implementation
{
Procedure TDList.ListInit(var First: pItem);
begin
  First := Nil;
end;

Procedure TDList.AddFirst(var First: pItem; x: tData);
var N: pItem;
begin
New(N); N^.Data:=x;
N^.Next:=First;
First:=N;
end;

Procedure TDList.AddLast(First: pItem; x: tData);
var N: pItem; Last: pItem;
begin
 New(N);
 N^.Data:=x;
 N^.Next:=Nil;
 Last:=First;
 While(Last^.Next<>Nil) do
 Last:= Last^.Next;
 Last^.Next:=N;
end;

Procedure TDList.Del(var First: pItem; Curr: pItem);
var Pred: pItem;
begin
  if Curr=First then
               begin
                 First:=Curr^.Next;
                 Dispose(Curr);
               end
               else begin
                 Pred:= First;
                 while Pred^.Next<>Curr do
                   Pred:=Pred^.Next;
                   Pred^.Next:=Curr^.Next;
                   Dispose(Curr);
               end;
end;
  }
end.
