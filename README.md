# MindBoxTest
<p align="left">В этом репозитории содержится решение тестового задания Mindbox на позицию <br>С# разработчика. Он составляет из себя непосредственно класс figuresCalculator, который позволяет рассчитывать необходимые данные для клиента, тестовое консольное приложение ConsoleApp1 с возможностью проверки класса через код и Unit тесты в папке MyTest. <br><br>Решением второго тестового задания является следующий SQL запрос:</p>

###

<br clear="both">

<h6 align="left">SELECT products.product_name as 'Имя продукта', pn.type_name as 'Имя категории'<br>FROM products<br>LEFT JOIN<br>products_type pn on products.id_productType = pn.id_type</h6>

###

<p align="left">Реализован он на базе следующей реляционной базы данных:</p>

###

<div align="center">
  <img height="200" src="https://i.imgur.com/C7SFKVj.png"  />
</div>

###

<p align="left">В которой таблицы имеют следующее содержание:</p>

###

<div align="center">
  <img height="200" src="https://i.imgur.com/lAeMbtg.png"  />
</div>

###

<p align="left">Результат выполнения запроса представлен ниже</p>

###

<div align="center">
  <img height="200" src="https://i.imgur.com/tbqdJO3.png"  />
</div>

###
