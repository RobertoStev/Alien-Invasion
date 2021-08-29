<h1> <b> Alien Invasion </b> </h1>

СЕМИНАРСКА РАБОТА ПО ВИЗУЕЛНО ПРОГРАМИРЊЕ


<ul>

<li> Роберто Стевковски - 171027 </li>

</ul>

<p>Проектот е едноставна 2D видео игра. Во играта главната цел на играчот е да ги уништи противничките свемирски бродови и да ги избегне препреките на патот.
Играчот управува со свемирски брод кој има можност да испукува куршуми со помош на тастерот space. Играчот со помош на стрелките се движи горе и доле со цел 
поуспешно да ги избегне препреките и да ги уништи противничките свемирски бродови. Со секој уништен свемирски брод играчот добива еден поен. Кога играчот ќе 
достигне одреден број на поени преминува во следниот левел во кој противничките свемирски бродови се движат со поголема брзина. </p>

![Picture1](https://user-images.githubusercontent.com/65564783/131262800-7f80239f-4ce7-40a1-96f0-b4e87970f845.png)

<p>При судир со препрека или друг свемирски брод, играта завршува и играчот може повторно да ја стартува играта со кликнување на enter. </p>

![Picture3](https://user-images.githubusercontent.com/65564783/131262803-7763699a-632a-4c33-9e27-b4336f619b92.png)

<h2> <b> Опис на имплементацијата  </b> </h2>

<p>Апликацијата е имплементирана во C# програмскиот јазик. Користена е една форма за играта. Апликацијата се состои од неколку функции, тајмер и PictureBox елементи.
На почетокот на апликацијата се иницијализирани потребните променливи. 

Користени се две функции за движење на свемирскиот брод на играчот и тоа Form1_KeyDown и Form1_KeyUp. Со помош на овие функции се проверува кое од копчињата за движење
е претиснато и според тоа се овозможува движењето.

Функциите RestartGame и GameOver се повикуваат кога играчот ќе ја заврши играта и служат да ги ресетираат променливите на почетните вредности и да ја стартуваат играта
повторно доколку играчот притисне enter.

Функцијата MakeBullet го креира куршумот со одредена големина и боја и се појавува на одредена позиција веднаш пред свемирскиот брод на играчот. Додека функцијата RemoveBullet
го отстранува куршумот кога ќе се судри со противнички свемирски брод, кога ќе удри во препрека или кога ќе излезе од екранот на играта.

Функцијата ChangeUfo во различен временски интервал ги прикажува противничките свемирски бродови во зависност од нивниот индекс.

Главната функција во апликацијата е MainTimerEvent. Оваа функција заедно со горенаведените функции Form1_KeyDown и Form1_KeyUp помага за движење на свемирскиот брод на играчот
и го ограничува истото во рамките на формата на играта. Исто така проверува дали во препреката ќе удри играчот или куршумот. Доколку удри играчот во препреката или во друг
свемирски брод се повикува функцијата GameOver, додека пак ако удри куршумот се повикува функцијата RemoveBullet која го брише куршумот. Исто така оваа функција ја зголемува
брзината на играта во зависност од освоените поени на играчот.
</p>