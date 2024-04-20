# Разработка информационно–справочного каталога туристической фирмы (2021)

Исходные данные к проекту:

Разработать электронный каталог для туристической фирмы, организованный в виде	 удобного подбора по клиентам, отелям и другим параметрам. Исходные данные к		 	проекту:												
1)	Данные о клиенте (ФИО, данные паспорта, адрес проживания, контакты).		
2)	Данные о туристическом продукте (туроператор, страна, курорт, название отеля,	 количество ночей, количество человек, стоимость).						
3)	Данные о транспорте (авиаперелет – дата и время вылете, номер рейса, компания;	 автобусный тур – дата и время отъезда, номер автобуса, компания).			
4)	Данные об отеле (стана, курорт, название, тип номера, питание).				

Разработке подлежат следующие компоненты программного обеспечения:			
1)	База данных для хранения информации о клиентах, туристическом продукте,		 транспорте, отеле проживания.									
2)	Интерфейс для ввода информации в базу данных;						
3)	Поиск информации по заданным критериям – по ФИО клиента, названию 		 отеля,названию туроператора, дате выезда и возвращения.	

## Интерфейс

При открытии приложения будет отображена главная форма с учетом действий клиентов.

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/a70625f9-5715-4d3d-8e70-59b2b40ed7aa)

Рисунок 4.1 – Главная форма

Используя меню вверху приложения можно перейти к любой из других четырех форм для взаимодействия с данными таблиц базы данных.

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/52fcf3ea-a2a6-4785-953a-3f47a45eedcc)

Рисунок 4.2 – Форма работы с клиентами

 ![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/43ca0ed9-6cfd-488d-bce4-e521dabf76d3)

Рисунок 4.3 – Форма работы с отелями

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/e56c73a6-1ba1-4559-b080-6222e6d45ded)

Рисунок 4.4 – Форма работы с турпродуктами

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/07fa5280-a1d3-4b0e-b459-4d5985a844b9)

Рисунок 4.5 – Форма работы с транспортом

Попробуем добавить новую запись. Для этого достаточно напистаь новую информацию в последнюю пустую строку таблицы.

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/9e32165a-a74f-4835-b003-dfec6d6ad5f1)

Рисунок 4.6 – Добавление новой записи

После внесения информации необходимо сохранить изменения, для чего стоит наать соответствующую кнопку. В результате чего появится окно подтверждения действия.

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/2f6ba454-3cd5-4283-8009-982925df0f59)

Рисунок 4.7 – Подтверждение сохранения

После подтверждения, пользователю будет показан результат сохранения данных.

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/a600330e-d15e-4790-a95d-9fccedba749f)

Рисунок 4.8 – Результат сохранения

Теперь новую запись можно видеть в общем списке. Можно заметить, что ей присвоился порядковый номер от всех записей.

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/4f99c9d8-a427-425d-9d25-8a86a07d05f6)

Рисунок 4.9 – Отображение новой зписи в таблице

Также, после обновления информации на главной странице теперь можно использовать только-что добавленные данные при добавлении записей.

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/dd991c9f-e856-4f6e-9ee1-a111bcbb660e)

Рисунок 4.10 – Отображение новой записи на главной форме

Данные добавляются и редактируются во всех формах аналогично. Теперь проверим результаты поиска по критериям. 

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/7fc80a2f-f8d2-4afd-ae24-72b8930f1196)

Рисунок 4.11 – Результат поиска по ФИО клиента

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/abddb712-ec7a-41d6-ae34-ef6be3be331c)

Рисунок 4.12 – Результат поиска по названию туроператора

 
![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/b0e146f4-e2d3-4a00-9eb4-b54fcf132858)

Рисунок 4.13 – Результат поиска по названию отеля

 ![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/181a4c97-5b87-44c9-93bd-2de947a8c0b5)

Рисунок 4.14 – Результат поиска по дате въезда


![image](https://github.com/Evgescha/Course-work---Development-of-an-information-and-reference-catalog-of-a-travel-company/assets/38140129/213b5b2d-3341-4850-96d3-8a1050d56efc)

Рисунок 4.15 – Результат поиска по дате выезда

По итогу   бартестирования, можно сделать бар вывод о том,  бар что приложение готово  бар корректно взаимодействовать с  бар пользователем и выполнять  бар весь необходимый функционал  бар быстродейтственно, что являлось  бар основной задачей для  бар разработки при‬ложения.
