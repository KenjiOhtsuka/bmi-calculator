# bmi-calculator

VB 2005 (Japanese) project for BMI calculation. Form Application
This project was created in 2005.

Calculate the followings

* BMI
* Basic Energy (基礎代謝)
* Ideal Height according to the Weight (体重から見た理想身長)
* Ideal Weight according to the Height (身長から見た理想体重)

## BMI (Body Mass Index)

Calculate BMI (BMIを計算します。)

BMI = 10000 * Weight[kg] / Hight[cm] ^ 2
(BMI = 10000 x 体重[kg] / 身長[cm] ^ 2)

## Basic Energy 基礎代謝

ハリス・ベネディクト方式で基礎代謝カロリーを計算します。

### For Male

Basic Energy = 66.5 + Weight[kg] * 13.75 + Hight[cm] * 5.003 - Age * 6.775
(基礎代謝 = 66.5 + 体重[kg] x 13.75 + 身長[cm] x 5.003 - 年齢 x 6.775)

### For Female

Basic Energy = 655.1 + Weight[kg] * 9.563 + Hight[cm] * 1.85 - Age * 4.676
(基礎代謝 = 655.1 + 体重[kg] x 9.563 + 身長[cm] x 1.85 - 年齢 x 4.676)
