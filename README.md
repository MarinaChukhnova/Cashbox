# Cashbox

Для запуска программы необходимо скопировать файл CashBook.exe с лазерного диска в созданный каталог и запустить программу
стандартными средствами (Windows Explorer, FAR Manager). При запуске приложения автоматически проверяется наличие баз данных 
и правильность пути к ним. Если базы данных не обнаружены, то выводиться сообщение об отсутствии баз данных и программа не загружается. 

Программно-методический комплекс предназначен для автоматизации учетно-кассовых операций на машиностроительном предприятии.

Пункт меню «Первичные документы» содержит:
1	Подпункт «Приходный кассовый ордер» – содержит таблицу базы данных сохраненных приходных кассовых ордеров и инструменты работы с ними.

Инструменты для работы с базой данных приходных кассовых ордеров:
-«Добавить» - осуществляет переход на форму с пустыми полями для заполнения нового приходного кассового ордера.
- «Добавить копированием» - осуществляет переход на форму с уже заполненными полями для создания нового приходного кассового ордера,
на основе данных ранее сохраненного, конкретно выбранного ПКО.
-«Редактировать» - осуществляет переход на форму заполнения приходного кассового ордера для редактирования данных ранее сохраненного
конкретно выбранного ПКО.
- «Удалить» - удаление из базы данных конкретно выбранного из таблицы приходного кассового ордера.
- «Фильтр» – в строке для ввода набираются данные для фильтрации в таблице ПКО. В зависимости от столбца поиска нажимается 
соответствующая запросу поиска кнопка («По имени», «По счетам», «По счету», «По основанию», «По приложению», «По номеру» 
«По всем документам»). Поиск по дате осуществляется нажатием на кнопку «По дате» и выбором соответствующего временного
интервала в ячейках с датами.
В графе сумма расхода автоматически суммируются все расходные ордера.

2 Подпункт «Расходный кассовый ордер» –  содержит таблицу базы данных сохраненных расходных кассовых ордеров и инструменты работы с ними. Инструменты для работы с базой данных расходных кассовых ордеров реализованы аналогично приходным кассовым ордерам и выполняют
те же функции.
В графе сумма расхода автоматически суммируются все расходные ордера.
В формах для заполнения кассовых ордеров реализованы такие команды как:
-	«Очистить» - сброс, очищение полей в форме.
-	«Сохранить» - сохранение заполненного кассового ордера в базе.
- «Экспорт в Word» - экспорт заполненной формы кассового ордера в Word (формат *.doc),в  в соответствующий бланк, установленный
Положением о ведении кассовых операций в национальной валюте в Украине.

Пункт меню «Отчетные документы» содержит следующие подпункты:
1	«Журнал регистрации кассовых ордеров» – содержит таблицу зарегистрированных кассовых ордеров и инструменты работы с ней.
 В форме работы с журналом кассовых ордеров есть такие инструменты управления:
- «Выделение по дате» - возможность выбора временного интервала в
ячейках с датами, маркировка цветом выбранных кассовых ордеров.
-  «Экспорт в Word» - экспорт таблицы журнала регистрации кассовых ордеров в MS Word  и сохранение в формате *.doc .

2	«Кассовая книга» – формирование отчета кассира за день. Расчет суммы прихода, суммы расхода и остатка на начало и конец наличных
средств в кассе.

Пункт меню «Справочники» содержит следующие подпункты:
­	«Счета» – просмотр, добавление данных о бухгалтерских корреспондирующих счетах (корреспонденция со счетом 301 «Касса в национальной
валюте»)
­	«Сотрудники» – просмотр, добавление данных о сотрудниках
­	«Лимит» – данные об установленном лимите в кассе предприятия.

Вкладка «Кассовые операции» позволяет выбрать вид, выполняемой кассовой операции содержит в себе две кнопки:
-  кнопка «Оприходование денежных средств в кассу» - осуществляет переход в форму выполнения данной кассовой операции, просмотр таблицы
базы данных сохраненных приходных кассовых ордеров и инструменты работы с ними;
-  кнопка «Выдача денежных средств из кассы» - осуществляет переход в форму выполнения данной кассовой операции, просмотр таблицы базы
данных сохраненных приходных кассовых ордеров и инструменты работы с ними;

Вкладка «Отчеты по кассовым операциям» позволяет выбрать вид отчетного документа, который необходимо сформировать. Содержит в себе две
кнопки: «Журнал регистрации кассовых ордеров», «Кассовая книга».









