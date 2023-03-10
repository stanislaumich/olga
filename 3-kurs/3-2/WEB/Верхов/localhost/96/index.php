<!-- index.php -->
<!--  далее идут заголовки файла для корректного отображения в браузере-->
<!DOCTYPE html>
<html lang='ru'>
<head>
    <meta charset='utf-8'>
    <title>Добро пожаловать!</title> 
</head>
<body>
<!-- начинается код-->
<?php
// тут мы переносим переменные параметры из глобального массива
// в локальный, сделано для безопасности на стороне сервера
// ограничение по передаче переменных
isset($_GET['act'])?$act = $_GET['act']:$act=0;
isset($_POST['nm'])?$nm = $_POST['nm']:$nm="";
isset($_POST['s1'])?$s1 = $_POST['s1']:$s1="0";
isset($_POST['s2'])?$s2 = $_POST['s2']:$s2="0";
// соединяемся с базой данных
$link = mysqli_connect("localhost", "root", "");
if ($link == false){
    print("Ошибка: Невозможно подключиться к MySQL " . mysqli_connect_error()."<br>");
}
else {
    echo "Соединение с базой данных установлено успешно<br>";
}
// если скрипт запускается впервые а базы не существует то создадим её
$sql = "CREATE DATABASE IF NOT EXISTS `magaz` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;";
$result = mysqli_query($link, $sql);
// и выберем для работы
$sql = "USE `magaz`;";
if (!isset($act)) $act = 0;
$result = mysqli_query($link, $sql);
// организуем выбор режимов и этапов работы
switch ($act)
{
 case 0:// часть которая выпоняется если нет параметров, основная 
        echo"<br><form action='index.php?act=1' method=POST><input type=submit value='Создать и заполнить базу'></form><br>";
        break; // выводим кнопку для создания и заполнения тоаблицы
	
 case 1: //  в этой части мы создаем таблицу, если её не существует
			echo"<br> База данных журналов создана и заполнена. Содержимое: <br><br>";
 			$sql = "CREATE TABLE IF NOT EXISTS`magaz`.`jour` (`name` VARCHAR(100) NOT NULL , `photo` VARCHAR(500) NULL , `god` INT NOT NULL , `nomer` INT NOT NULL , `izd` VARCHAR(300) NOT NULL , `pages` INT NOT NULL , `cena` FLOAT NOT NULL ) ENGINE = InnoDB;";
			$result = mysqli_query($link, $sql);
			// а если существует то очищаем
			$sql = "TRUNCATE TABLE `magaz`.`jour`";
			$result = mysqli_query($link, $sql);
			// и вставляем 10 записей с журналами
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Охота и рыбалка', '1.jpg', '1995', '1', 'Издательство 1', '10', '23.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Крючки и спицы', '2.jpg', '1996', '2', 'Издательство 2', '20', '13.1');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Кухня', '3.jpg', '1997', '3', 'Издательство 3', '30', '203.11');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Ремонт', '4.jpg', '1998', '4', 'Издательство 4', '40', '23.00');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Кройка и шитьё', '5.jpg', '1999', '5', 'Издательство 5', '50', '150.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Борщ и щи', '6.jpg', '2000', '6', 'Издательство 6', '60', '77.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Спид-Инфо', '7.jpg', '2001', '7', 'Издательство 7', '70', '86.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Банк и финансы', '8.jpg', '2002', '8', 'Издательство 8', '80', '69.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Телевизор', '9.jpg', '2003', '9', 'Издательство 9', '90', '5.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Мода', '10.jpg', '2004', '10', 'Издательство 10', '100', '36.12');";
			$result = mysqli_query($link, $sql);
			// выводим жданные в таблицу
			echo"<table border=1>";// начало таблицы			
			$sql = 'SELECT * FROM jour';// выбираем все записи
			$result = mysqli_query($link, $sql);
			// выводим заголовки таблицы
			echo"<tr><th>Название</th><th>Фото</th><th>Год</th><th>Номер</th><th>Издание</th><th>Страниц</th><th>Цена</th></tr>";
			while ($row = mysqli_fetch_array($result)) {// и по каждой записи из выборки
			echo"<tr><td>" . $row['name'] . "</td><td><img src='" . $row['photo'] . "' width=100></td><td>". $row['god'] . "</td><td>". $row['nomer'] . "</td>";
			echo "<td>" . $row['izd'] . "</td><td>". $row['pages'] . "</td><td>". $row['cena'] . "</td></tr>";
			} // формируем строки таблицы			
			echo"</table>";// закрываем таблицу
			// далее выводим кнопки с выбором варианта действий
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
		break;
 case 2: // Выбрано действие поиска журнала по названию, создаем форму
			echo"<br><form action='index.php?act=21' method=POST>
			<br>Введите название журнала:<input type=text name='nm'><br>			
			<input type=submit value='Вывести'></form>"; // в ней запрашиваем название
			// далее выводим кнопки с выбором варианта действий			
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
        break;
case 21: // выбираем журнал по названию, nm - параметр с названием, формируем запрос
			$sql = "SELECT * FROM jour where name='".$nm."'";
			$result = mysqli_query($link, $sql);
			// выводим данные в таблицу
			echo"<table border=1>";
			echo"<tr><th>Название</th><th>Фото</th><th>Год</th><th>Номер</th><th>Издание</th><th>Страниц</th><th>Цена</th></tr>";
			while ($row = mysqli_fetch_array($result)) {
			echo"<tr><td>" . $row['name'] . "</td><td><img src='" . $row['photo'] . "' width=100></td><td>". $row['god'] . "</td><td>". $row['nomer'] . "</td>";
			echo "<td>" . $row['izd'] . "</td><td>". $row['pages'] . "</td><td>". $row['cena'] . "</td></tr>";
			}
			echo"</table>";
			// далее выводим кнопки с выбором варианта действий
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
        break;
		
 case 3:    // выводим форму для выбора диапазона страниц
			echo"<br><form action='index.php?act=31' method=POST>
			<br>Введите страницы от:<input type=text name='s1'> и до:<input type=text name='s2'><br>			
			<input type=submit value='Вывести'></form>";
			// далее выводим кнопки с выбором варианта действий
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
        break;
 case 31:	// формируем запрос с параметрами s1 и s2
			$sql = "SELECT * FROM jour where pages between ".$s1." and ".$s2;
			$result = mysqli_query($link, $sql);
			// выводим результат таблицей
			echo"<table border=1>";
			echo"<tr><th>Название</th><th>Фото</th><th>Год</th><th>Номер</th><th>Издание</th><th>Страниц</th><th>Цена</th></tr>";
			while ($row = mysqli_fetch_array($result)) {
			echo"<tr><td>" . $row['name'] . "</td><td><img src='" . $row['photo'] . "' width=100></td><td>". $row['god'] . "</td><td>". $row['nomer'] . "</td>";
			echo "<td>" . $row['izd'] . "</td><td>". $row['pages'] . "</td><td>". $row['cena'] . "</td></tr>";
			}
			echo"</table>";
			// далее выводим кнопки с выбором варианта действий							
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
        break;		
}

?>
</body></html>