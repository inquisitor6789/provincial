﻿gs'stat'
'Вы подняли трубку и мужской голос сказал "Привет <<$name[1]>>, это Владимир, хочешь покататься на катере?"'
act 'Ой, у меня много дел, я сегодня никак не могу':
	cla
	vladimirday = day
	'(Вы) - Ой, у меня много дел, я сегодня никак не могу.'
	'(Владимир) - Ладно. Тогда я позвоню вам завтра в 4 вечера.'
	act 'Повесить трубку':gt'korr'
end
act 'Я не против':
	cla
	vladimirQW = 30
	vladimirday = day
	'(Вы) - Я не против.'
	'(Владимир) - Замечательно. Сейчас за тобой приедет мой водитель Слава и отвезет тебя.'
	act 'Повесить трубку':gt'korr'
end