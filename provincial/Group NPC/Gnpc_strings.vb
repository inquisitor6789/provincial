﻿!разговор о беременности
if $args[0] = 'preg_talk1': $result = 'Вы сказали парню, что забеременели от него. Он сильно удивился сказанному, от чего у него чуть не вылезли глаза из орбит.'
if $args[0] = 'preg_talk2': $result = 'Парень задумался:<br><do>- Слушай, я не готов стать отцом, да ещё и жениться на тебе.</do><br>Он протянул вам пять тысяч:<br><do>- Возьми деньги, и давай расстанемся.</do>'
if $args[0] = 'preg_talk3': $result = 'В ярости вы обложили парня матом, послав куда подальше. Но протянутую купюру таки выдернули из его рук. После чего развернулись и ушли.'
if $args[0] = 'preg_talk4': $result = 'Вас охватила ярость, вы в сердцах послали парня и ушли.'
if $args[0] = 'preg_talk5': $result = 'Парень возмутился:<br><do>- Да ты охуела, шалава! Кому-то подставила свою манду, а теперь будешь с меня бабки качать? Да пошла ты нахуй!</do>'
if $args[0] = 'preg_talk6': $result = 'В ярости вы послали парня, куда подальше, и ушли..'
!разговоры с парнем
if $args[0] = 'boy_talk1': $result = 'Вы обвинили парня в том, что он разболтал о ваших отношениях всем, и теперь окружающие считают что вы <<$gnikname>>'
if $args[0] = 'boy_talk2': $result = '<<$nameBoyfrend[numnpc]>> начал божиться, что он "случайно, по пьяни одному приятелю сказал, а тот, сука, всем разболтал". <<$nameBoyfrend[numnpc]>> клятвенно обещает, что больше такого не повторится.'
if $args[0] = 'boy_talk3': $result = '<<$nameBoyfrend[numnpc]>> начал успокаивать вас, дескать, ничего страшного не случилось: "поболтают и забудут".'
if $args[0] = 'boy_talk4': $result = '<<$nameBoyfrend[numnpc]>> усмехнувшись, сказал:<br><do>- Да расслабься! Ты же и есть самая настоящая <<$gnikname>> - чего такого-то?</do>'
if $args[0] = 'boy_talk5': $result = 'Вас охватила ярость, вы покрыли парня матюками и ушли.'
if $args[0] = 'boy_talk6': $result = 'Вы подумали немного и решили простить парня.'
if $args[0] = 'boy_talk7': $result = 'Вы гуляете с парнем по парку и весело болтаете.'
!сообщения при прогулке с парнем
if $args[0] = 'boy_walk1': $result = 'Вы видите, что вам навстречу идет Витёк Котов. Он подходит к парню и без прелюдий бьёт его по лицу. <<$nameBoyfrend[numnpc]>> падает на землю. Витёк наклоняется над ним:<br><do>- Слышь, ты, уёбок, это моя девчонка! Ещё раз увижу тебя с ней - живым в лесу закопаю, понял?</do> - парень кивает головой и заверяет, что понял.'
if $args[0] = 'boy_walk2': $result = '<<$nameBoyfrend[numnpc]>> предложил сходить в кино.'
if $args[0] = 'boy_walk3': $result = 'Вы пошли с парнем в кинотеатр в парке. <<$nameBoyfrend[numnpc]>> купил билеты в кино. Вы вместе вошли в небольшой кинозал и нашли свои места.'
if $args[0] = 'boy_walk4': $result = 'Вы сели с парнем на заднем ряду. Вскоре свет погас, и на экране началось кино.'
if $args[0] = 'boy_walk5': $result = 'Вы смотрели фильм пару часов, сидя в кресле рядом с парнем.'
if $args[0] = 'boy_walk6': $result = 'Вы стали смотреть кино, как вдруг ощутили ладонь парня на своей коленке.'
if $args[0] = 'boy_walk7': $result = 'Вы убрали ладонь парня со своей ноги и продолжили смотреть кино. Фильм закончился, в зале загорелся свет, и на экране пошли титры.'
if $args[0] = 'boy_walk8': $result = 'Вы сделали вид, что ничего не происходит, и парень начал еще активней гладить вашу ногу. Кино закончилось, в зале загорелся свет, и на экране пошли титры.'
if $args[0] = 'boy_walk9': $result = 'Вы стали смотреть кино, а <<$nameBoyfrend[numnpc]>> положил свою руку вам на ногу и начал поглаживать коленку. Кино кончилось, в зале загорелся свет, и на экране пошли титры.'
if $args[0] = 'boy_walk10': $result = '<<$nameBoyfrend[numnpc]>> предложил попить пивка в парке.'
if $args[0] = 'boy_walk11': $result = 'Вы пошли с парнем к ближайшему киоску. <<$nameBoyfrend[numnpc]>> купил пива и закуску. После чего вы пошли к лавочке в дальнем уголке сквера.'
if $args[0] = 'boy_walk12': $result = '<<$nameBoyfrend[numnpc]>> разлил пиво по стаканам. Вы сидите с ним и пьёте пиво. <<$nameBoyfrend[numnpc]>> рассказывает разные смешные истории.'
if $args[0] = 'boy_walk13': $result = 'Вы допили пиво вместе с парнем и хорошо провели время.'