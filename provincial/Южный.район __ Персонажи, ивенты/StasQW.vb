﻿if $ARGS[0] = 'cafe':
	*clr & cla
	minut += 5
	gs 'stat'
	gs 'zz_render', '', 'images/city/south/stas/cafe_start.jpg', 'Вы сели на стул и Стас, жестом подозвав официантку, заказал бутылку вина и закуску к нему. Когда заказ принесли Стас, разлив вино по бокалам, произнёс:**<do>- Давай за знакомство!</do>'
	act 'Выпить за знакомство':
		*clr & cla
		minut += 5
		gs 'zz_funcs', 'alko', 1
		gs 'stat'
		gs 'zz_render', '', 'images/city/south/stas/cafe_drink.jpg', 'Вы выпили и Стас начал рассказывать веселые истории подливая вино в бокалы.'
		act 'Выпивать и болтать':
			*clr & cla
			minut += 30
			horny += 5
			body['day_weight'] += 1
			gs 'zz_funcs', 'alko', rand(1,2)
			water = 24
			energy = 24
			gs 'stat'
			gs 'zz_render', '', 'images/city/south/stas/cafe_talk.jpg', 'Вы расслабились и попивая вино слушали байки, которыми вас потчевал Стас. За болтовней вы даже не заметили, как Стас заказал еще одну бутылку, пока наконец не поняли, что уже прилично набрались. Тут в кафе заиграла музыка и Стас, встав со своего стула, галантно протянул вам руку, предлагая потанцевать.'
			act 'Танцевать':
				*clr & cla
				minut += 5
				horny += 5
				gs 'stat'
				gs 'zz_render', '', 'images/city/south/stas/cafe_dance.jpg', 'Вы вышли на танцпол и Стас крепко обнял вас и вы начали танцевать. Его руки во время танца плавно сползли с талии вам на бедра и начали гладить их. Вы почувствовали как ладонь Стаса сжала вашу мягкую попу.'
				if horny < 70 or shameless['flag'] < 1:
					act 'Поднять его руки выше':
						cla
						minut += 5
						horny += 5
						gs 'stat'
						gs 'zz_render', '', '', 'Вы взяли руки Стаса и подняли их опять себе на талию. Стас только шире заулыбался и опять его руки начали сползать вам на попу.'
						if horny < 70 or shameless['flag'] < 1:
							act 'Опять поднять его руки выше':
								*clr & cla
								minut += 5
								horny += 5
								gs 'stat'
								gs 'zz_render', '', 'images/city/south/stas/cafe_dance_hands.jpg', 'Вы опять взяли руки Стаса и подняли их себе на талию. Стаса видимо от этого только охватил азарт и он начал нежно поглаживая вашу спину плавно спускаться вам руками на попку. Наконец танец закончился.'
								act 'Сесть за стол':
									*clr & cla
									minut += 30
									gs 'zz_funcs', 'alko', rand(1,2)
									gs 'stat'
									gs 'zz_render', '', 'images/city/south/stas/cafe_eat.jpg', 'После танца вы вернулись за столик и продолжили общение, выпивая и закусывая.'
									act 'Далее':
										*clr & cla
										minut += 5
										gs'stat'
										gs 'zz_render', '', 'images/city/south/stas/cafe_bill.jpg', 'Наконец, когда всё было съедено и выпипито, официантка принесла счет. Вы взглянули на цифру и слегка обалдели.**<dh>- Пять тысяч! В этом кафе?! -</dh> воскликнули вы глядя на счёт.**<do>- Не парься, я заплачу.</do> - сказал Стас забирая бумажку из ваших рук.'
										if money >= 5000 or karta >= 5000:
											act 'Нет спасибо, я сама оплачу':
												*clr & cla
												minut += 5
												gs 'zz_render', '', 'images/city/south/stas/cafe_pay_'+iif(money >= 2500,'money','karta')+'.jpg', 'Вы достали '+iif(money >= 2500,'деньги','кредитку')+' и расплатились с официанткой. Стас встал со своего места и подал вам руку. Оперевшись о его руку вы поднялись с насиженного места и вместе ним вышли из кафе.'
												if money >= 5000:
													money -= 5000
												else
													karta -= 5000
												end
												gs'stat'
												act 'Идти':
													*clr & cla
													minut += 15
													gs'stat'
													gs 'zz_render', '', 'images/city/north/youry/gt_youri'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg', iif(alko >= 3,'Довольно не уверенным шагом, от количества выпитого алкоголя, вы направились домой. ','')+'По дороге к дому, Стас галантно '+iif(alko >= 3,'поддерживал','держал')+' вас под руку, развлекая рассказами. На конец добравшись до дома, Стас провёл вас до квартиры и явно ожидает, что вы его пригласите в гости.'
													if shameless['flag'] > 0 or horny >= 70:act 'Пригласить к себе': gt 'StasQW','sex_start'
													act 'Попрощаться':
														*clr & cla
														gs 'zz_render', '', 'images/city/south/stas/close_door.jpg', 'Вы попрощались со Стасом и тот грустно вздохнул и пошел вниз.'
														act 'Закрыть дверь': gt'korr'
													end
												end
											end
										end
										act 'Ой, это так мило!':
											*clr & cla
											minut += 5
											gs'stat'
											gs 'zz_render', '', 'images/city/south/stas/cafe_pay_stas.jpg', 'Вы обрадовались, что не придется платить за кафе и Стас, расплатившись с официанткой кредиткой, встал со стула и подал вам руку. Оперевшись о его руку вы поднялись с насиженного места и вместе вышли из кафе.'
											act 'Идти':
												*clr & cla
												minut += 15
												gs'stat'
												gs 'zz_render', '', 'images/city/north/youry/gt_youri'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg', iif(alko >= 3,'Довольно не уверенным шагом, от количества выпитого алкоголя, вы направились домой. ','')+'По дороге к дому, Стас галантно '+iif(alko >= 3,'поддерживал','держал')+' вас под руку, развлекая рассказами. Наконец добравшись до дома, Стас провёл вас до квартиры и явно ожидает, что вы его пригласите в гости. Вы помялись на пороге, думая как бы отшить Стаса, но глядя на него вы чувствуете себя обязанной ему. Он нашел вам работу, он раскошелился за кафе, хотя это была ваша обязанность, и выставить его за порог вы просто не можете.'
												act 'Пригласить к себе': gt 'StasQW','sex_start'
											end
										end
									end
								end
							end
						end
						act 'Танцевать': gt 'StasQW','cafe_dance'
					end
				end
				act 'Танцевать': gt 'StasQW','cafe_dance'
			end
		end
	end
end
if $ARGS[0] = 'cafe_dance':
	*clr & cla
	minut += 5
	horny += 10
	gs'stat'
	gs 'zz_render', '', 'images/city/south/stas/cafe_dance_pants.jpg', 'Вы продолжили танцевать и распаленный Стас стал засовывать вам руки под юбку.'+iif(tanga > 0,' Вскоре Стас нащупал ваши трусики и запустил туда руку.','')+' Вас охватило возбуждение, когда Стас нащупал ваш маленький бугорок клитора и стал его ласкать. Внезапно танец закончился, но Стас явно не собирался садится за стол обратно...'
	act 'Сесть за стол':gt 'StasQW','cafe_horny'
end
if $ARGS[0] = 'cafe_horny':
	*clr & cla
	minut += 30
	horny += 10
	gs 'zz_funcs', 'alko', rand(1,2)
	gs'stat'
	gs 'zz_render', '', 'images/city/south/stas/cafe_touch.jpg', 'После танца Стас за руку отвел вас к столику и взяв вас за талию усадил к себе на колени. Он тут же начал вас целовать и вы почувствовали как его рука опять проникла вам под юбку начав ласкать ваш клитор. Стас зашептал вам в ушко:**<do>- Пойдем к тебе, или может развлечемся в туалете?</do>'
	act 'Пойдем ко мне!':
		*clr & cla
		gs'stat'
		gs 'zz_render', '', 'images/city/south/stas/cafe_pay_stas.jpg', 'Стас расплатился с официанткой, после чего встал со стула и подал вам руку. Оперевшись о его руку, вы поднялись с насиженного места и вместе со Стасом вышли из кафе.'
		act 'Идти':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/city/north/youry/gt_youri'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg', iif(alko >= 3,'Довольно не уверенным шагом, от количества выпитого алкоголя, вы направились домой. ','')+'По дороге к дому, Стас галантно '+iif(alko >= 3,'поддерживал','держал')+' вас под руку, развлекая рассказами. Наконец добравшись до дома, Стас провёл вас до квартиры и когда вы открыли дверь он буквально втащил вас в вашу внутрь.'
			act 'Пригласить к себе': gt 'StasQW','sex_start'
		end
	end
	if horny > 90 or shameless['flag'] > 1:
		act 'Можно и в туалете':
			*clr & cla
			minut += 5
			gs'stat'
			gs 'zz_render', '', 'images/city/south/stas/cafe_wait.jpg', '<dh>- Можно и в туалете, -</dh> согласились вы'+iif(alko >= 3,', пьяно улыбнувшись','')+'.**<do>- Хорошо, тогда иди первая, -</do> сказал Стас.<do> - Не будем привлекать лишнего внимания.</do>**Вы'+iif(alko >= 3,' покачнувшись','')+' встали и отправились в сторону туалета. Зайдя внутрь вы присели на унитаз в ожидании прихода Стаса. Наконец раздался осторожный стук в дверь, которую вы тут же открыли. Войдя внутрь Стас тут же впился в ваши губы страстным поцелуем.**<dh>- Подожди, -</dh> прошептали между поцелуями.<dh> - Дверь нужно закрыть...</dh>**Стас, не выпуская выс из объятий протянул руку и вы услышали как счёлкнул замок на двери.'
			act 'Сосать':
				*clr & cla
				if StasikSex = 0: StasikSex += 1 & guy += 1
				bj += 1
				minut += 5
				$boy = 'Стасик'
				dick = 15
				silavag = 1
				pose = 1
				gs'stat'
				gs 'zz_render', '', 'images/city/south/stas/cafe_bj.jpg', 'Вы опустились перед Стасом на колени и взяв в руку член поднесли к своим губам.'
				gs 'zz_dynamic_sex', 'bj'
				gs 'zz_render', '', '','<do>- Я так кончу скоро! -</do> простонал Стас.'
				act 'Сосать дальше':
					*clr & cla
					minut += 5
					gs 'zz_funcs', 'cum', 'face'
					gs'stat'
					gs 'zz_render', '', 'images/city/south/stas/cafe_cumface.jpg', 'Вы с удвоенным старанием принялись работать своим ротиком. Застонав, Стас вынул член из вашего рта, и тут же начал кончать, обильно орошая ваше лицо вязкой и тёплой спермой.'+iif(hour < 17,'**<do>- <<$name[2]>>, ты тут давай, приводи себя в порядок, а я побежал в офис, -</do> сказал Стас, застёгивая брюки.<do> - Рабочий день ещё не закончился, как никак...</do>','')
					if hour < 17:
						act 'Далее': gt 'kafe','toilet'
					else
						act 'Далее': cumface = 0 & gt 'StasQW','go_home'
					end
				end
				if vgape < 2:
					act 'Отдаться':
						*clr & cla
						minut += 5
						pose = 1
						gs'stat'
						gs 'zz_render', '', 'images/city/south/stas/cafe_vag.jpg', 'Вы встали раком, забравшись на опущенную крышку унитаза, и Стас начал пристраиваться к вашей <<$vaginatipe3>> киске.'
						gs 'zz_dynamic_sex', 'sex_start'
						gs 'zz_dynamic_sex', 'vaginal', 'dick'
						gs 'zz_dynamic_sex', 'sex_cum'
						if hour < 17:
							gs 'zz_render', '', '', '<do>- <<$name[2]>>, ты тут давай, приводи себя в порядок, а я побежал в офис, -</do> сказал Стас, застёгивая брюки.<do> - Рабочий день ещё не закончился, как никак...</do>'
							act 'Далее': gt 'kafe','toilet'
						else
							act 'Далее': cumpussy = 0 & gt 'StasQW','go_home'
						end
					end
				end
				act 'Подставить попу':
					*clr & cla
					minut += 5
					gs'stat'
					gs 'zz_render', '', 'images/city/south/stas/cafe_anal.jpg', 'Вы встали раком, забравшись на опущенную крышку унитаза, и Стас начал пристраиваться к вашей <<$anustipe3>> задней дырочке.'
					gs 'zz_dynamic_sex', 'anal_start', 'dick'
					gs 'zz_dynamic_sex', 'anal', 'dick'
					gs 'zz_dynamic_sex', 'anal_cum'
					if hour < 17:
						gs 'zz_render', '', '', '<do>- <<$name[2]>>, ты тут давай, приводи себя в порядок, а я побежал в офис, -</do> сказал Стас, застёгивая брюки.<do> - Рабочий день ещё не закончился, как никак...</do>'
						act 'Далее': gt 'kafe','toilet'
					else
						act 'Далее': cumanus = 0 & gt 'StasQW','go_home'
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'go_home':
	*clr & cla
	minut += 15
	gs'stat'
	gs 'zz_render', '', 'images/city/north/youry/gt_youri'+iif(month >= 4 and month <= 10,'','_winter')+'.jpg', 'Быстро приведя себя в порядок, вы со Стасиком, держась за руки и весело разговаривая, отправились в сторону вашего дома. Проводив вас до квартиры и поцеловав на прощание, он побежал вниз по лестнице, радостно насвистывая на ходу.'
	act 'Закрыть дверь': gt'korr'
end
if $ARGS[0] = 'sex_start':
	minut += 5
	horny += 5
	gs'stat'
	gs 'zz_render', '', 'images/city/south/stas/kiss.jpg', 'Вы вошли в квартиру и Стас разувшись, сразу же впился в ваши губы поцелуем и вы почувствовали как его руки охватили ваши груди, начав ласкать их и сжимать. Не прекращая поцелуй и постоянно натыкаясь на различные препятствия, вы начали перемешаться в комнату.'
	act 'Идти в комнату':
		*clr & cla
		horny += 5
		gs 'zz_render', '', 'images/city/south/stas/undress.jpg', 'Войдя в комнату Стас принялся стягивать с вас одежду, не прекращая ласкать ваше тело.'
		act 'Далее':
			*clr & cla
			horny += 5
			gs 'zz_render', '', 'images/city/south/stas/tits.jpg', 'Добравшись до вашей груди, он впился в неё губами, лаская языком, вырвав из ваших уст стон наслаждения.'
			act 'Далее':
				*clr & cla
				gs 'zz_render', '', 'images/city/south/stas/undress_stas.jpg', 'Оторвав его от вашей груди, вы принялись раздевать его, растёгивая и снимая с него одежду.'
				act 'Сосать':
					*clr & cla
					minut += 5
					gs'stat'
					gs 'zz_render', '', 'images/city/south/stas/bj.jpg', 'В процессе раздевания Стаса, вы опускались всё ниже и ниже, попутно покрывая его тело лёгкими поцелуями, пока не опустились перед ним на колени. Справившись с застёжкой ремня, вы стянули с него брюки и его член тут же уткнулся в ваши <<$liptalk3>> губы.'
					gs 'zz_dynamic_sex', 'bj'
					gs 'zz_render', '', '', '<do>- Не спеши -</do> простонал Стас.<do> - А то я так кончу скоро!</do>'
					act 'Расслабиться':
						*clr & cla
						horny += 20
						minut += 5
						gs'stat'
						gs 'zz_render', '', 'images/city/south/stas/kuni.jpg', 'Стас подхватил вас на руки и опрокинув на диван, тут же с жадностью впился губами в вашу '+iif(horny < 50,'',iif(horny < 90,'изнывающую','текущую'))+' киску губами'
						if horny >= 100:
							horny = 0
							manna = 100
							orgasm += 1
							gs 'zz_render', '', '', 'Постепенно приятное тепло и пульсация нарастают внизу живота, потом ощущения обрушиваются на вас, и все ваше тело охватывают горячие волны оргазма.'
							act 'Далее':
								*clr & cla
								horny += 50
								minut += 5
								gs'stat'
								gs 'zz_render', '', 'images/city/south/stas/finger.jpg', 'Видя ваш бурный оргазм, Стас не спешит переходить к более активным действиям, давая вам передохнуть. Он проник в вшу киску <<vaginatipe2>> киску пальцами, а губами прильнул к вашей груди, играя и дразня языком сосок, возбуждая вас заново.'
								gs 'StasQW','sex'
							end
						else
							gs 'zz_render', '', '', 'Действия парня хоть и были возбуждающие, но постепенно они начали вас утомлять...'
							gs 'StasQW','sex'
						end
					end
				end
			end
		end
	end
end
if $ARGS[0] = 'sex':
	$boy = 'Стасик'
	dick = 15
	silavag = 1
	act 'Отдаться':
		*clr & cla
		minut += 5
		pose = 0
		gs'stat'
		gs 'zz_render', '', 'images/city/south/stas/vag.jpg', 'Вы лежите на диване, наслаждаясь ласками парня. Стас приподнял задрал ваши ноги вверх и вы тут же почувствовали как в вашу киску упёрся его член.'
		gs 'zz_dynamic_sex', 'sex_start'
		gs 'zz_dynamic_sex', 'vaginal', 'dick'
		act 'Стонать':
			*clr & cla
			minut += 15
			gs'stat'
			gs 'zz_render', '', 'images/city/south/stas/vagcum.jpg', 'Вскоре дыхание парня участилось и он начал двигаться в вас быстрее.'
			gs 'zz_dynamic_sex', 'sex_cum'
			gs 'zz_render', '', '', '<do>- Всё было замечательно <<$name[2]>>, -</do> сказал Стас, поцеловав вас в губы.**Приняв душ, он оделся и поцеловав вас на прощание, отправился к выходу из квартиры.'
			act 'Закрыть за Стасом дверь': gt'korr'
		end
	end
	act 'Подставить попу':
		*clr & cla
		minut += 5
		gs'stat'
		gs 'zz_render', '', 'images/city/south/stas/anal.jpg', 'Стас положил вас на бок и начал пристраиваться к вашей <<$anustipe3>> задней дырочке.'
		gs 'zz_dynamic_sex', 'anal_start', 'dick'
		gs 'zz_dynamic_sex', 'anal', 'dick'
		act 'Стонать':
			*clr & cla
			minut += 15
			gs 'zz_funcs', 'cum', 'anus'
			gs'stat'
			gs 'zz_render', '', 'images/city/south/stas/analcum.jpg', 'Вскоре дыхание парня участилось, он начал двигаться в вас быстрее, а ещё через мгновение <<$boy>> застонал, и вы почувствовали как вашу попу наполняет тепло.**<do>- Всё было замечательно <<$name[2]>>, -</do> сказал Стас, поцеловав вас в губы.**Он принял душ, оделся, и поцеловав вас на прощание, отправился к выходу из квартиры.'
			act 'Закрыть за Стасом дверь': gt'korr'
		end
	end
end