<!-- index.html -->
<!DOCTYPE html>
<html lang='ru'>

<head>
    <meta charset='utf-8'>
    <title>Добро пожаловать!</title> 
</head>

<body>

<?php
$act = $_GET['act'];
$link = mysqli_connect("localhost", "root", "");
if ($link == false){
    print("Ошибка: Невозможно подключиться к MySQL " . mysqli_connect_error()."<br>");
}
else {
    echo "Соединение с базой данных установлено успешно<br>";
}
$sql = "CREATE DATABASE IF NOT EXISTS `magaz` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;";
$result = mysqli_query($link, $sql);
$sql = "USE `magaz`;";
if (!isset($act)) $act = 0;
$result = mysqli_query($link, $sql);
switch ($act)
{
 case 0: echo"<br><form action='index.php?act=1' method=POST><input type=submit value='Создать и заполнить базу'></form><br>";
        break; 
	
 case 1: echo"<br> База данных журналов создана и заполнена. Содержимое: <br><br>";
 
			$sql = "CREATE TABLE `magaz`.`jour` (`name` VARCHAR(100) NOT NULL , `photo` VARCHAR(500) NULL , `god` INT NOT NULL , `nomer` INT NOT NULL , `izd` VARCHAR(300) NOT NULL , `pages` INT NOT NULL , `cena` FLOAT NOT NULL ) ENGINE = InnoDB;";
			$result = mysqli_query($link, $sql);
			$sql = "TRUNCATE TABLE `magaz`.`jour`";
			$result = mysqli_query($link, $sql);			
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Охота и рыбалка', 'p', '1995', '1', 'Издательство 1', '10', '23.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Крючки и спицы', 'p', '1996', '2', 'Издательство 2', '20', '13.1');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Кухня', 'p', '1997', '3', 'Издательство 3', '30', '203.11');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Ремонт', 'p', '1998', '4', 'Издательство 4', '40', '23.00');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Кройка и шитьё', 'p', '1999', '5', 'Издательство 5', '50', '150.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Борщ и щи', 'p', '2000', '6', 'Издательство 6', '60', '77.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Спид-Инфо', 'p', '2001', '7', 'Издательство 7', '70', '86.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Банк и финансы', 'p', '2002', '8', 'Издательство 8', '80', '69.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Телевизор', 'p', '2003', '9', 'Издательство 9', '90', '5.12');";
			$result = mysqli_query($link, $sql);
			$sql = "INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES ('Мода', 'p', '2004', '10', 'Издательство 10', '100', '36.12');";
			$result = mysqli_query($link, $sql);
			
			
			

 
 
 
 
			echo"<table border=1>";
			
			$sql = 'SELECT * FROM jour';
			$result = mysqli_query($link, $sql);
			echo"<tr><th>Название</th><th>Фото</th><th>Год</th><th>Номер</th><th>Издание</th><th>Страниц</th><th>Цена</th></tr>";
			while ($row = mysqli_fetch_array($result)) {
			echo"<tr><td>" . $row['name'] . "</td><td>" . $row['photo'] . "</td><td>". $row['god'] . "</td><td>". $row['nomer'] . "</td>";
			echo "<td>" . $row['izd'] . "</td><td>". $row['pages'] . "</td><td>". $row['cena'] . "</td></tr>";
			}
			
			
			
			echo"</table>";
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
		break;
 case 2:
 
 
 
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
        break; 	
 case 3:
 
			
			
			echo"<br><form action='index.php?act=0' method=POST><input type=submit value='Первая страница'></form>";
			echo"<br><form action='index.php?act=2' method=POST><input type=submit value='Задание А'></form>";
			echo"<br><form action='index.php?act=3' method=POST><input type=submit value='Задание Б'></form>";
        break; 		
}

?>
</body></html>