﻿grandmaage = age + 42
*clr & cla
minut += 2
if grandmaknowsick = 1 and sick = 0:grandmaknowsick = 0
gs 'stat'
'<center><B>Бубушка</B></center>'
if $loc = 'Gadhouse':
	if hour = 6:'<center><img src="images/qwest/gadukino/new/grandma_cooking'+rand(1,5)+'.jpg"></center>'
	if hour = 7 or hour = 13 or hour = 18:'<center><img src="images/qwest/gadukino/new/grandma_eat.jpg"></center>'
	if hour > 19 and hour < 22:'<center><img src="images/qwest/gadukino/new/grandma_tv.jpg"></center>'
	if month < 4 or month > 9 or sunWeather < 0:
		if hour > 7 and hour < 13:
			'<center><img src="images/qwest/gadukino/new/grandma_cooking'+rand(1,5)+'.jpg"></center>'
		elseif hour > 13 and hour < 18:
			'<center><img src="images/qwest/gadukino/new/grandma_knits.jpg"></center>'
		end
	end
elseif $loc = 'Gadgarden':
	'<center><img src="images/qwest/gadukino/new/grandma_gadgarden.jpg"></center>'
elseif $loc = 'Gadsarai':
	if hour = 19:
		'<center><img src="images/qwest/gadukino/new/grandma_cow.jpg"></center>'
	else
		'<center><img src="images/qwest/gadukino/new/grandma_gadsarai.jpg"></center>'
	end
elseif $loc = 'gadukino':
	'<center><img src="images/qwest/gadukino/new/grandma_gadukino.jpg"></center>'
elseif $loc = 'gadmarket':
	'<center><img src="images/qwest/gadukino/new/grandma_gadmarket.jpg"></center>'
else
	'<center><img src="images/qwest/gadukino/grandma.jpg"></center>'
end
'Ваша бабушка много лет проработала дояркой в колхозе, но после его развала осталась без работы. И уже много лет занимается домашним хозяйством - многочисленной живностью и садом-огородом. Деревенская нелёгкая жизнь рано её состарила. Хотя она и чуть моложе деда, но выглядит настоящей "старушкой".'
if grandmaQW < 20: 'У вас с ней ужасный скандал.'
if grandmaQW >= 20 and grandmaQW < 40: 'У вас с ней напряженные отношения.'
if grandmaQW >= 40 and grandmaQW < 60: 'У вас с ней нормальные отношения.'
if grandmaQW >= 60 and grandmaQW < 80: 'У вас с ней хорошие отношения.'
if grandmaQW >= 80: 'У вас с ней отличные отношения.'
if grandmaQW < 0:grandmaQW = 0
if grandmaQW > 100:grandmaQW = 100
if current_clothing = 0:
	grandma_notalk = 1
	grandmaQW -= 10
	if grandmaknownude > 0:' - <<$name>>, опять за старое принялась? Ты чего опять голая ходишь? А ну марш домой одеваться, пока дубца не получила!!!.'
	if grandmaknownude = 0:grandmaknownude += 1 & ' - <<$name[1]>>, ты что здесь делаешь в таком виде? А ну марш домой одеваться!Не хватало, чтобы вся деревня увидела, что ты тут голышом разгуливаешь, стыда потом не оберешься!.'
end
if cumlip + cumface + cumfrot > 0:
	grandma_notalk = 1
	grandmaQW -= 10
	if grandmaQW < 40:
		'Бабушка посмотрела на вас, выпучила глаза и покраснела. На вас была заметна сперма.'
		if grandma_know = 0:grandma_know = 1 & '- Это что такое на тебе? Я думаю, что у меня внучка приличная, а она ебется непонятно с кем. Пошла прочь отсюда, чтобы я тебя не видела!'
		if grandma_know = 1:'- Опять где-то трахалась шлюха малолетняя? Мне уже перед знакомыми стыдно за тебя! Пошла отсюда, не попадайся мне на глаза!'
	else
		if grandma_know = 0:
			grandma_know = 1
			'Бабушка присмотрелась к вам внимательным взглядом. На вас была заметна сперма. Она ойкнула и запричитала.'
			'- <<$name[3]>>, внучка, что такое на тебе? Что же это делается? Я то думаю, что у меня внучка приличная, а оно вот как выходит. Быстро приведи себя в порядок, пока еще кто-нибудь не увидел!'
		else
			'Бабушка строго посмотрела на вас. На вас была заметна сперма..'
			'- <<$name[1]>>, опять ты за своё? Быстро приведи себя в порядок, пока еще кто-нибудь не увидел!'
		end
	end
end
if alko > 0 and age < 20:
	grandma_notalk = 1
	if alko < 3:
		grandmaQW -= 1
		'Онa принюхалась:'
		' - <<$name[1]>>, от тебя спиртным пахнет! Что за безобразие? Ты еще слишком молода, чтобы пить! Иди приведи себя в порядок.'
	elseif alko >= 3 and alko < 6:
		grandmaQW -= 5
		'Она принюхалаь и внимательно глянула на вас:'
		' - Господи, <<$name[1]>>, ты пьяная? Ты же еще так молода, как тебе не стыдно! Иди приведи себя в порядок, сейчас же!'
	elseif alko >= 6:
		grandpaQW -= 5
		minut += 20
		gs 'zz_bathroom', 'clean_me'
		'Она внимательно глянула и грозно посмотрела на вас:'
		' - <<$name>> ты что, напилась? Господи ты, боже мой! Что же это делается такое!'
		'Бабушка ещё что-то говорила и причитала, но вы слабо понимали, что она говорит и делает. Спустя пять минут причитаний, она обняла вас за плечи и подвела в баню, где хорошенько умыла вас. После бабушка отвела вас в избу и уложила в кровать.'
	end
end
if grandmahelpday ! daystart and grandma_notalk = 0 and current_clothing > 0 and grandmaknowsick = 0 and alko = 0:act 'Предложить помощь':grandmahelpday = daystart & gt'grandmahelp'
if grandmatalkgad = 0 and grandma_notalk = 0 and current_clothing > 0 and alko = 0:
	act 'Спросить про деревню':
		cla
		*clr
		grandmatalkgad = 1
		minut += 10
		manna += 5
		grandmaQW += 1
		gs 'stat'
		'<center><B>Бубушка</B></center>'
		'<center><img src="images/qwest/gadukino/grandma.jpg"></center>'
		'Вы сели рядом с бабушкой, решив узнать побольше о деревне.'
		' - А ты что не помнишь, <<$name[3]>>? Ты же бывала не раз у нас в деревне, - удивилась бабушка.'
		' - Так я ж мелкая была, дома в основном сидела, да с Митькой на речку купаться бегали, - ответили вы.'
		' - А сейчас уже крупная стала! Поглядите-ка на неё, - засмеялась бабушка. - Ну ладно, слушай.'
		'И начала рассказывать про деревню.'
		' - Деревня у нас небольшая, ну ты это и сама знаешь. Про речку и пляж рассказывать не буду, помнишь же, что с Митькой там купались и загорали. Еще там рыбаков можно встретить, если Степка будет, может дать и удочку порыбачить.'
		' В самой деревне ничего интересного нет. Митька только с друзьями шатаются, да по вечерам самогон пьют. Ах, да... вспомнила... недавно к нам новая семья из города переехала, отец с дочкой. Представляешь? Там девочка твоего возраста примерно, хоть и городская, но работящая говорят. Если будешь гулять по деревне, то обязательно встретишься и познакомишься с ней.'
		' За деревней есть поле, на котором пасут скот, и лес. В лесу наш местный охотник Андрей всё пропадает. К нему как приезжие дружки понаедут, так они потом сутками оттуда не вылазят. Говорят у них там избушка есть где-то охотничья. Так, что если встретишь их там, не удивляйся. Но про лес это ты к деду иди спрашивай.'
		' Если любишь спортом заниматься, то можно побегать по дороге, ведущей в лес. Или на нашем старом велосипеде покататься. Кстати поищи его в сарае. А если за фигурой следишь, то сходи в сад, покушай фруктов, они как ваша городская еда диетическая, если не лучше.'
		' Ну все внучка, беги гуляй, не отвлекай меня. Сейчас десять тысяч стопятьдесят восьмая серия "Санта-Барбары" начнется, не хочу пропустить.'
		act 'Закончить':gt $loc, $metka
	end
end
if $loc = 'gadmarket' and mesec > 0 and tampon < 5 and alko = 0:
	act 'Попросить купить тампоны':
		cla
		*clr
		minut += 5
		manna += 5
		grandmaQW += 1
		if grandmaQW >= 20:tampon += 20
		gs 'stat'
		'<center><B>Бубушка</B></center>'
		'<center><img src="images/qwest/gadukino/grandma.jpg"></center>'
		'Увидев бабушку в магазине вы подошли к ней.'
		' - Бабуль, - начали вы, отчаянно краснея. - У меня тут .... ээээ... женские дела, короче. Не могла бы ты мне тампонов купить?.'
		if grandmaQW < 20: ' - Нет <<$name>>, - ответила она. - Ты сначала научись вести себя нормально, тогда и другие тебе тем же отвечать будут. А пока выпутывайся сама как хочешь.'
		if grandmaQW >= 20 and grandmaQW < 40:
			' - Во, как что-то нужно, так сразу "бабуля". А как хорошо вести себя, так мы не умеем, - проворчала она. - Ладно уж, держи, что с тобой поделаешь.'
			'И заплатив продавщице протянула вам упаковку тампонов.'
		end
		if grandmaQW >= 20:	' - Конечно <<$name[3]>>, держи, - сказала бабушка и заплатив продавщице протянула вам упаковку тампонов..'
		act 'Уйти':gt $loc, $metka
	end
end
if sick > 0 and grandmaknowsick = 0 and alko = 0:
	act 'Сказать, что вы заболели':
		cla
		*clr
		minut += 5
		manna += 5
		grandmaQW += 1
		grandmaknowsick = 1
		if lekarstvo = 0:lekarstvo += 10
		gs 'stat'
		'<center><B>Бубушка</B></center>'
		'<center><img src="images/qwest/gadukino/grandma.jpg"></center>'
		'Вы подошли к бабушке и сказали, что плохо себя чувствуете. Она внимательно осмотрев вас и потрогав лоб воскликнула:'
		' - Господи, да ты заболела! А ну-ка выпей таблетку и марш в постель, чтобы на улице я тебя не видела.'
		act 'Уйти':gt 'Gadhouse'
	end
end
if grandmatalk ! hour and grandma_notalk = 0 and current_clothing > 0 and alko = 0:
	act 'Поболтать':
		*clr & cla
		grandmatalk = hour
		gs 'stat'
		'<center><B>Бубушка</B></center>'
		'<center><img src="images/qwest/gadukino/grandma.jpg"></center>'
		if $loc = 'Gadhouse' or $loc = 'gadukino' or $loc = 'gadmarket':
			minut += 10
			manna += rand(5,10)
			if grandmaQW < 60:grandmaQW += 1
			if grandmaQW < 60:'Вы некоторое время болтаете со своей бабушкой, но все что вами удается почерпнуть из разговора, это то, что молодежь уже не та.'
			if grandmaQW >= 60:'Вы, некоторое время, болтаете со своей бабушкой разные темы, и довольные разговором расходитесь.'
		else
			minut += 1
			manna -= 5
			'- Нет времени внучка, работать нужно.'
		end
		act 'Закончить':gt $loc, $metka
	end
end
if grandmastory ! daystart and grandma_notalk = 0 and current_clothing > 0 and alko = 0:
	act 'Попросить рассказать историю':
		*clr & cla
		grandmastory = daystart
		gs 'stat'
		'<center><B>Бубушка</B></center>'
		'<center><img src="images/qwest/gadukino/'+iif($loc = 'Gadhouse','Babushka','grandma')+'.jpg"></center>'
		if $loc = 'Gadhouse' or $loc = 'gadukino':
			minut += 20
			manna += rand(5,10)
			temp = RAND(0,7)
			if grandmaQW < 80:grandmaQW += 1
			'Вы просите свою бабушку рассказать вам какую-нибудь из ее многочисленных историй и она, немного поворчав, все же охотно соглашается...'
			if temp = 0:
				'- Однажды собрались девчонки и мальчишки, у одного друга, в гостях, - начинает свой рассказ бабуля. - Родители по гостям ушли, и остались они одни дома, человек пять-семь. Вот время спать уже, легли, а года это 195.. Ох, не помню уже, прости, внучка, давно это уже было... В общем, света ещё не было в деревнях, и одна девочка, которая возле стены лежала, пошутить решила, и начала, тихо-тихо в стенку стучать. Все испугались, а на дворе зима, ветер свистит тихо, ну узнали что девчонка стучала, покричали на неё чуть-чуть, и опять спать легли.
И вот опять в стенку стучать стало, девчонку на пол постелили, а тут опять стучат. Все испугались и в центр комнаты собрались, все сидят к друг дружку прижавшись. А тут то в одну стену постучат, то в другую.Часа в четыре метель прекратилась, а снег шёл, и он перестал идти, в окно было видно.
Так до шести утра стучало. А в семь родители пришли. Дети всё родителям рассказали, а они им не поверили. Выбежали дети на улицу, а вокруг дома ни следа на снегу нет.
С тех пор никто из них, даже в дверь не стучал, голосом звали.'
			elseif temp = 1:
				' - Была у меня когда-то подружка, начинает бабуля. - Умер у нее муж, пьяницей он был. Напился и умер. И вот один раз, пришла она с работы, села на диван, и слышит, кто-то в коридоре идёт. Доски под ногами у кого-то скрипят. А дверь из коридора в комнату, деревянная со стеклом, посередине. А стекло ребристое, и подруга моя увидела только тень от человека, на мужа её очень похожая. Не на шутку перепугавшись, она сказала: "Уйди, а если не уйдёшь кочергой прогоню..." - И ушёл он. На следующей неделе она опять с работы приходит, а у неё сервант со стеклянной дверцей. Она решила книжку почитать, взяла книгу, поворачивается, а за стеклом муж её стоит. Она как стеклянной дверцей в него запустит, ему по голове ударило дверцей, он на неё посмотрел и ушёл. Потом она другой подруге рассказала, и та ей посоветовала живность какую-нибудь завести, кошечку или собачку. Завела она собачку. Вернулась очередной раз с работы, заходит в комнату, а он на диване лежит. Ну она собаке и приказала "выгоняй его, выгоняй" - ну собака на него давай лаять, а муж встал, помахал ей рукой и ушёл. Больше он никогда к ней не приходил, а собачка ещё 15 лет прожила... Славная была...'
			elseif temp = 2:
				'- Родилась я, как ты, наверное, знаешь, в совсем другой деревне, начинает рассказывать бабуля. - Так вот, история эта случилась давно, я еще маленькая была. У одного мужика из нашей деревни умер отец, а затем, не прошло и двух недель, умер и родной брат. А в деревне поверье у нас было, если не прошло, сорок дней со смерти одного покойника и умер другой, то жди третьего. Дело зимой было. И вот мужик этот, у которого родные умерли, поехал на санях к родственникам за десять километров, а назад возвращался уже по-темному. Дорога через поле шла, хотя какая зимой дорога, один санный след и то, если снегом не заметет. Как вдруг лошадь около перелеска как вкопанная встала и храпеть начала. Мужик, имени его я не помню, уж прости, внученька, подумал на волков, за ружье схватился... Обернулся, а на санях, позади него, покойные брат с отцом сидят. И отец говорит:
- Подвезешь до дома?
Мужик с саней спрыгнул и бежать бросился в сторону деревни, прямо по сугробам и бежал, пока головой в церковь, что в его деревне стоит, не врезался. На следующее утро на службу в церковь пришел, батюшке покаялся. Лошадь его так и не нашли, а самого мужика через десять дней нашли в колодце... мертвого...'
			elseif temp = 3:
				' - Эта история произошла, еще тогда, когда я совсем юная была, почти как ты, молодая. здоровая. Это было послевоенное время, когда никто не верил ни в какие потусторонние силы, а люди думали только о том, как прокормить себя и свою семью. Ну так вот, наступила ночь, все мы спать легли ужо, только кошка тревожно сидела в темном углу и на что-то шипела. А когда кто-то из моих родителей встал посмотреть, в чем дело, не обнаружил ничего странного. Наутро, чистя печь от золы, кошку обнаружили мертвой в печке. Как она туда попала – неизвестно! При этом никто из нас не слышал больше ночью потусторонних звуков. Чертовщина какая-то, ей богу, - разводит руками бабуля, хитро щуря слезящиеся глаза.'
			elseif temp = 4:
				'- Расскажу тебе в этот раз о таком случае: В село "Укромное", первомайского района, в котором я когда пару лет жила, приехала женщина с севера из Заполярья. Она жила одна и к ней в дом забрел красавец пес - белый, большой, спокойный. Через некоторое время он умер. Она погоревала, но что добру пропадать? Сняла с него шкуру и сделала себе раскошенный воротник. Прошло около двух месяцев. Она заболела...Я пришла, все выглядело нормально. Но вдруг хлопнула дверь, возник сквозняк и как реакция на стук и ветер, у нее возникли характерные для бешенства судороги. Было уже поздно вакцинировать и женщина умерла... Такое вот было...'
			elseif temp = 5:
				'- Как-то в молодости в новогодние праздники одним зимним вечером сидели мы с подругами на кухне у моей подружки, - начинает бабуля. - К ней пришла в гости наша школьная подруга, вот мы и собрались тогда. Так втроем устроили посиделки. Моя подруга говорит, мол, давайте погадаем на воске, сейчас святки как раз. И начали гадать себе по очереди. У меня получилась фигура мужского профиля, у которого нос был прямой и с горбинкой. Этот профиль держал в руках, что-то вроде букета цветов. У подруги моей получилась абстрактная фигура, похожая на чайник. А у ее школьной подруги – вышел образ маленького ребенка. Решили закрепить еще раз, сжечь бумагу и посмотреть тени на стене. В этот раз у меня отчетливо нарисовался большой пароход. У моей подруги – ничего особенного, а вот у третьей девочки опять ребенок, только уже с коляской. Эта школьная подруга не была замужем и детей у нее не было. Все, посидели и начали расходиться. Ко мне в это время должен был подъехать мой молодой человек. Я спустилась вниз, а он уже приехал и достает из машины красивый букет роз для меня. Повода никакого не было, просто он захотел сделать мне приятное. Я удивилась, потому что вспомнила сразу мужской профиль на воске с букетом цветов. Но через 4 месяца я познакомилась с другим мужчиной, твоим дедушкой, за которого и вышла потом замуж. И он, как ты знаешь, действительно имеет прямой нос с горбинкой. Получается, что цветы мне подарил один, а замуж я вышла за другого... Но самое интересное у этой школьной подруги – она действительно родила ребенка в конце того года, когда мы гадали. Вот и не верь этим гаданиям...'
			elseif temp = 6:
				'- Помню, сидели мы как-то, начинает бабуля, но потом, словно что-то вспомнив, горестно вздыхает. - А спичек-то больше нет...
Вы удивленно смотрите на свою бабушку, а потмо спрашиваете, что она имеет ввиду, ведь он же они спички, на кухне лежат, да и в магазине купить можно, на что-то бабуля вам отвечает:
- Ничего ты не понимаешь, внученька. Сейчас уже не те спички, что раньше были. А закончились те, что я во время войны на фабрике наворовала... Ох и спички были, не то что сейчас... Тьфу...'
			elseif temp = 7:
				'- Как-то моя мама, царствие ей небесное, всех нас четверых послала в лес за ягодой, рассказывает вам бабуля. - Мы, вооружившись соответствующей тарой, дружной толпой отправились туда. Прибежав на свою поляну, мы разбрелись по своим заветным местам и молча собирали ягоду. Мне досталася делянка около огромного пня, вокруг которого рос густой кустарник. Здесь я увидела очень большое количество спелой земляники. Я присела на корточки и, радуясь, что я больше соберу, чем мои братья, потихоньку собираю ягоду и кладу её в стакан, подвязанный на поясе. Вдруг слышу какой-то шорох. Я поворачиваюсь на этот звук, но опять тихо. Нигде никого нет, никого не видно. Я опять собираю ягоду. Так повторилось несколько раз. И вдруг… Я вижу на пне, сквозь кустарник, на корточках сидящего человека. Он руками раздвигал кустарник и смотрел на меня. Мне стало страшно. Я с криком и плачем побежала к братьям. Они пытались меня остановить, успокоить, но я продолжала свой бег. Братья бежали за мной, а за нами бежал тот человек. Вдруг старший брат крикнул: «Бежим на бригаду*!». А бригадой у нас центральная усадьба колхоза звалась, - поясняет вам бабуля. - Она была совсем близко от леса. Когда мы выбежали из леса, человек этот уже не преследовал нас. Прибежав на бригаду, братья рассказали об этом бригадиру. Он сразу схватил телефонную трубку и стал куда-то звонить. А нас успокаивали колхозники. Немного придя в себя, мы пошли домой. Дома мама нас накормила, напоила и утешила.
На следующий день нам сообщили, что недалеко от станции Ратомка были разобраны рельсы железной дороги.
Видимо это и был тот мужчина, который бежал за нами. Дело в том, что в довоенные годы к нам проникали шпионы, диверсанты, которые вели подрывную работу, а пронинуть было легко, так как территория покрыта лесами, простирающимися до самых границ.
Этот страх, этот ужас, который я испытала тогда, в детском, ещё дошкольном возрасте, запал в мою душу настолько, что я незабуду его до конца моей жизни...'
			end
		else
			minut += 1
			manna -= 5
			'- Не время сейчас внучка, потом расскажу.'
		end
		act 'Закончить':gt $loc, $metka
	end
end
act 'Уйти':
	if alko < 6 and grandmaknowsick = 0 and current_clothing > 0:gt $loc, $metka
	if alko < 6 and grandmaknowsick = 1 or current_clothing = 0:gt 'Gadhouse'
	if alko >= 6:$loc = 'Gadhouse' & gt 'bed', 'sleep'
end