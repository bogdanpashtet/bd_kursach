# А-12-19 Замалютдинов Руслан
# Курсовая работа по курсу: "Базы данных" 5 семестр

# Задание

Мы являемся торговой интернет-площадкой, специализирующейся на продаже 3D моделей. Пользователи нашей площадки могут выставить на продажу свои работы или купить подходящую модель у другого пользователя. Естественно, все работы проходят строгий контроль.
Любой пользователь должен иметь доступ к списку продавцов (нужно, чтобы сортировать данный список можно было по общему количеству продаж продавца, по общей оценке его работ или по количеству его работ) и списку возможных категорий товаров (персонажи, архитектура, оружие, одежда, посуда, животные и т.д.). В идеале можно было бы совместить фильтры по категориям и продавцам. Продавцы, помимо вышеперечисленного, могут также ознакомиться со своей личной статистикой: общее количество продаж по месяцам, полученная прибыль по месяцам и за всё время (с учётом процента, отданного площадке), оценка пользователей его работ, популярность тех или иных его работ.
Каждый пользователь может поставить оценку продавцу (от 1 до 5) или оставить жалобу на работу того или иного продавца (низкое качество работы, несоответствие описания товара действительности, провокационность работы).
Продавцом может стать лишь пользователь, прошедший регистрацию (никнейм, электронная почта, номер телефона и номер карты). 	
Информация о всех продавцах и жалобах на них доступна администраторам площадки. В случае выявления нарушения продавцом пользовательского соглашения и правил площадки администратор может заблокировать страницу пользователя (пользователь попадает в чёрный лист площадки).	
Информация о количестве пользователей, посетивших площадку за день/неделю/месяц/за всё время, количестве запросов по категориям, общей выручке по месяцам и за всё время доступна аналитикам площадки.
Список аналитиков и администраторов доступен старшему администратору. Только он может вносить изменения в эти списки (при увольнении или найме сотрудников).

![image](https://user-images.githubusercontent.com/58053351/195686226-c739672f-7d0d-44ba-a966-e1afd2df3400.png)
