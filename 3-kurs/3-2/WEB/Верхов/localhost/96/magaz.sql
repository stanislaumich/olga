-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 10 2023 г., 00:18
-- Версия сервера: 8.0.30
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `magaz`
--
CREATE DATABASE IF NOT EXISTS `magaz` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `magaz`;

-- --------------------------------------------------------

--
-- Структура таблицы `jour`
--

CREATE TABLE `jour` (
  `name` varchar(100) NOT NULL,
  `photo` varchar(500) DEFAULT NULL,
  `god` int NOT NULL,
  `nomer` int NOT NULL,
  `izd` varchar(300) NOT NULL,
  `pages` int NOT NULL,
  `cena` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `jour`
--

INSERT INTO `jour` (`name`, `photo`, `god`, `nomer`, `izd`, `pages`, `cena`) VALUES
('Охота и рыбалка', 'p', 1995, 1, 'Издательство 1', 10, 23.12),
('Крючки и спицы', 'p', 1996, 2, 'Издательство 2', 20, 13.1),
('Кухня', 'p', 1997, 3, 'Издательство 3', 30, 203.11),
('Ремонт', 'p', 1998, 4, 'Издательство 4', 40, 23),
('Кройка и шитьё', 'p', 1999, 5, 'Издательство 5', 50, 150.12),
('Борщ и щи', 'p', 2000, 6, 'Издательство 6', 60, 77.12),
('Спид-Инфо', 'p', 2001, 7, 'Издательство 7', 70, 86.12),
('Банк и финансы', 'p', 2002, 8, 'Издательство 8', 80, 69.12),
('Телевизор', 'p', 2003, 9, 'Издательство 9', 90, 5.12),
('Мода', 'p', 2004, 10, 'Издательство 10', 100, 36.12);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
