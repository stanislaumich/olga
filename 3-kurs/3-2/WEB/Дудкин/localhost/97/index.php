<!-- index.php -->
<!--  заголовки файла для корректного отображения в браузере-->
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
isset($_POST['et'])?$et = $_POST['et']:$et="";
isset($_POST['sq1'])?$sq1 = $_POST['sq1']:$sq1="0";
isset($_POST['sq2'])?$sq2 = $_POST['sq2']:$sq2="0";
// соединяемся с базой данных
$link = mysqli_connect("localhost", "root", "");
// если скрипт запускается впервые а базы не существует то создадим её
$sql = "CREATE DATABASE IF NOT EXISTS `KVART` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;";
$result = mysqli_query($link, $sql);
// и выберем для работы
$sql = "USE `KVART`;";
if (!isset($act)) $act = 0;
$result = mysqli_query($link, $sql);
// организуем выбор режимов и этапов работы
switch ($act)
{
 case 0:// часть которая выпоняется если нет параметров, основная
        echo"Спроектировать структуру базы данных о квартирах, предназначенных для продажи:<br>
 		район, этаж, площадь, количество комнат, сведения о владельце, цена.<br>
Запросы:<br>
а) вывести информацию о квартирах, расположенных на заданном этаже;<br>
б) вывести информацию о квартирах, имеющих площадь из указанного интервала.<br>
"; 
        echo"<br><form action='index.php?act=1' method=POST><input type=submit value='Заполнить базу данных'></form><br>";
        break; // выводим кнопку для создания и заполнения тоаблицы
	
 case 1: //  в этой части мы создаем таблицу, если её не существует
			echo"<br> База данных квартир создана и заполнена. Содержимое: <br><br>";
 			$sql = "CREATE TABLE IF NOT EXISTS `dat` (`raon` VARCHAR(100) NOT NULL , `mast` VARCHAR(500) NULL , `etag` INT NOT NULL , `sq` FLOAT NOT NULL , `rooms` INT NOT NULL ,  `cena` FLOAT NOT NULL ) ENGINE = InnoDB;";
			$result = mysqli_query($link, $sql);
			// а если существует то очищаем
			$sql = "TRUNCATE TABLE `dat`";
			$result = mysqli_query($link, $sql);
			// и вставляем 10 записей с журналами
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Ленинский', 'Иванов И. И.', '1', '18.22', '3',  '23120');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`, `cena`) VALUES ('Первомайский', 'Петров П. П.', '2', '28.33', '2',  '13100');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Новогиреево', 'Сидоров С. С.', '3', '39.21', '1',  '2031125');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`, `cena`) VALUES ('Измайловский', 'Кетин К. К.', '4', '49.17', '4',  '23256');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Шабаны', 'Шаблин Ш. Ш.', '1', '56.77', '4',  '150758');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Серебрянка', 'Рамин Р. Р.', '2', '65.23', '3',  '772544');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Центр', 'Ольгина О. О.', '3', '25.36', '3',  '86000');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Фатина', 'Зетова И. И.', '4', '45.66', '2', '697582');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Колос', 'Почубеев П. Ч.', '1', '78.22', '1', '545263');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `dat` (`raon`, `mast`, `etag`, `sq`, `rooms`,  `cena`) VALUES ('Персвомайский', 'Кривонос К. К.', '2', '43.14', '1',  '364210');";
			$result = mysqli_query($link, $sql);
			// выводим жданные в таблицу
			echo"<table border=1>";// начало таблицы			
			$sql = 'SELECT * FROM dat';// выбираем все записи
			$result = mysqli_query($link, $sql);
			// выводим заголовки таблицы
			echo"<tr><th>Район</th><th>Владелец</th><th>Этаж</th><th>Площадь</th><th>Комнат</th><th>Цена</th></tr>";
			while ($row = mysqli_fetch_array($result)) {// и по каждой записи из выборки
			echo"<tr><td>" . $row['raon'] . "</td><td>" . $row['mast'] . "</td><td>". $row['etag'] . "</td><td>". $row['sq'] . "</td>";
			echo "<td>" . $row['rooms'] . "</td><td>". $row['cena'] . "</td></tr>";
			} // формируем строки таблицы			
			echo"</table>";// закрываем таблицу
			// далее выводим кнопки с выбором варианта действий
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Начало'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание 1'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание 2'></form>";
		break;
 case 2: // Выбрано действие поиска журнала по названию, создаем форму
			echo"<br><form action='index.php?act=21' method=POST>
			<br>Введите этаж:<input type=text name='et'><br>			
			<input type=submit value='Найти'></form>"; // в ней запрашиваем название
			// далее выводим кнопки с выбором варианта действий			
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Начало'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание 1'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание 2'></form>";
        break;
case 21: // выбираем квартиру по этажу, et - параметр с  этажом, формируем запрос
			$sql = "SELECT * FROM dat where etag='".$et."'";
			$result = mysqli_query($link, $sql);
			// выводим данные в таблицу
			echo"<table border=1>";
			echo"<tr><th>Район</th><th>Владелец</th><th>Этаж</th><th>Площадь</th><th>Комнат</th><th>Цена</th></tr>";
			while ($row = mysqli_fetch_array($result)) {
			echo"<tr><td>" . $row['raon'] . "</td><td>" . $row['mast'] . "</td><td>". $row['etag'] . "</td><td>". $row['sq'] . "</td>";
			echo "<td>" . $row['rooms'] . "</td><td>". $row['cena'] . "</td></tr>";
			}
			echo"</table>";
			// далее выводим кнопки с выбором варианта действий
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Начало'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание 1'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание 2'></form>";
        break;
		
 case 3:    // выводим форму для выбора диапазона страниц
			echo"<br><form action='index.php?act=31' method=POST>
			<br>Введите страницы от:<input type=text name='sq1'> и до:<input type=text name='sq2'><br>			
			<input type=submit value='Найти'></form>";
			// далее выводим кнопки с выбором варианта действий
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Начало'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание 1'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание 2'></form>";
        break;
 case 31:	// формируем запрос с параметрами s1 и s2
			$sql = "SELECT * FROM dat where sq between ".$sq1." and ".$sq2;
			$result = mysqli_query($link, $sql);
			// выводим результат таблицей
			echo"<table border=1>";
			echo"<tr><th>Район</th><th>Владелец</th><th>Этаж</th><th>Площадь</th><th>Комнат</th><th>Цена</th></tr>";
			while ($row = mysqli_fetch_array($result)) {
			echo"<tr><td>" . $row['raon'] . "</td><td>" . $row['mast'] . "</td><td>". $row['etag'] . "</td><td>". $row['sq'] . "</td>";
			echo "<td>" . $row['rooms'] . "</td><td>". $row['cena'] . "</td></tr>";
			}
			echo"</table>";
			// далее выводим кнопки с выбором варианта действий							
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Начало'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание 1'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание 2'></form>";
        break;		
}

?>
</body></html>