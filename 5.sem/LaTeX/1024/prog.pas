unit Unit10;  // Nagy számok törvénye

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics,
  Controls, Forms, Dialogs, StdCtrls, ExtCtrls, math;

type
  TForm10 = class(TForm)
    Panel1: TPanel;
    Button1: TButton;
    Button2: TButton;
    Button5: TButton;
    Button6: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    procedure Button6Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Kezdet(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
    procedure Torles;
    procedure TengelyX;
    procedure TengelyY;
    procedure BeosztasX(i: real);
    procedure PirosPont(a, b: real);
    procedure KekPont(a, b: real);
    procedure Fuggvenyabra;
    function Fuggveny(t: real): real;
  public
    { Public declarations }
  end;

var
  Form10: TForm10;
  x1, x2, y1, y2: real;
  pontszam, gyak: integer;

implementation

uses Unit1, Unit11;

{$R *.dfm}

// Kezdet
procedure TForm10.Kezdet(Sender: TObject);
begin
Panel1.Left := Trunc((Screen.Width - Panel1.Width) / 2);
Button1.Top := Screen.Height - 30;
Button2.Top := Screen.Height - 30;
Button5.Top := Screen.Height - 30;
Button6.Top := Screen.Height - 30;
Label1.Top := 5;
Label2.Top := Label1.Top + Label1.Height + 5;
Label3.Top := Label2.Top + Label2.Height + 5;
Label4.Top := Screen.Height - 25;
Button1.Enabled := true;
Button2.Enabled := false;
Button5.Enabled := true;
Button6.Enabled := true;
end;

// Kilépés
procedure TForm10.Button6Click(Sender: TObject);
begin
Form1.Close;
end;

end.



