# 13 logging and monitoring

## общее

В данном задании мы добавим счётчики производители и логгирование
к уже имеющемуся проекту.

По умолчанию предлагается взять за основу приложение _MvcMusicStore_,
обновлённое на ASP.NET MVC 5 (его можно найти в архиве _Task.zip_).

**Примечание!!! Выбор проекта,
в который встраивается логгирование и мониторинг,
а также библиотеку, которая будет использоваться для записи логов,
согласуйте с ментором.**

## 01 счётчики производительности

Добавьте несколько счётчиков производительности в ваш проект.

Если вы используете _MvcMusicStore_, то добавьте счётчики:
*   Число успешных LogIn
*   Число успешных LogOff
*   1 на ваш выбор

Для регистрации и удаления счётчиков может потребоваться
отдельное приложение
(которое необходимо будет запускать с повышенными привилегиями).

При выполнении задания вы можете использовать
как непосредственно классы `System.Diagnostics`,
так и сторонние библиотеки-надстройки, такие как _Performance Counter Helper_.

## 02 логгирование

Добавьте запись логов для выбранного проекта.

Необходимо соблюсти следующие условия:
*   Должно поддерживаться несколько уровней логгирования
    (как минимум `Error`, `Info`, `Debug`)
*   Логгирование должно включаться/отключаться
    через конфигурационный файл

## 03 сбор и анализ логов

Используя API или командную строку _Log Parser_,
создайте генератор отчётов по логам.

В отчёте должно фигурировать:
*   Общее количество каждого типа записей
*   Перечень ошибок (записей с кодом `Error`)