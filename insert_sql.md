# Insert SQL

<a name="contents"></a>
## Contents

* [SQL Insert Statements](#sql-statement)

***

<a name="sql-statement"></a>
## SQL Insert Statements

Table 1 (Roommate)
```
INSERT INTO roommate (rid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("1", "Cole Krizek", "kcole", "password123", "colekrizek@gmail.com", "25NOV2022", "M", "1508 Northglen ST Wichita", "KS", "USA", 67220)

INSERT INTO roommate (rid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("2", "Colleen Ann", "AC", "pas2352", "ca@gmail.com", "25FEB2022", "F", "1508 Maple ST Wichita", "KS", "USA", 67220)

INSERT INTO roommate (rid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("3", "Beth Trust", "BethT", "Jerry133f", "Beth@yahoo.com", "02APR2021", "F", "1852 Cherry ST Wichita", "UT", "USA", 54483)

INSERT INTO roommate (rid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("4", "John Robert", "JRob", "t232t2g", "Jrob@outlook.com", "08MAR2021", "M", "2525 Peace ST Abilene", "UT", "USA", 57883)

INSERT INTO roommate (rid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("5", "Brian Carry", "Jzwfg", "coswavbiejt", "Bcar@outlook.com", "18OCT2020", "M", "15912 Dirt ST Parry", "AZ", "USA", 15613)

```

Table 2 (LandLord)

```
INSERT INTO landlord (lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("1", "Eric Robs", "EricR", "Egi252#4", "Ericr@outlook.com", "12MAR2020", "M", "15912 Dirt ST Parry", "AZ", "USA", 15613)

INSERT INTO landlord (lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("2", "Terry Robs", "TerryR", "f24$*#&vv", "TRobs@outlook.com", "13MAR2020", "M", "159234 Dirt ST Parry", "WA", "USA", 15613)

INSERT INTO landlord (lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("3", "Susan Ban", "SBan", "f2fbveb2#", "Sban@outlook.com", "07JUN2020", "F", "123 Lane ST", "NY", "USA", 54789)

INSERT INTO landlord (lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("4", "Calli Reeves", "CalRev", "pass2345t", "calRev@outlook.com", "01JUL2022", "F", "1534 Appea ST", "OR", "USA", 57845)

INSERT INTO landlord (lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("5", "Bently Bark", "Wbiatr", "weovPASSt", "RevBarfe@gmail.com", "02JAN2022", "F", "4548 Mountain View ST", "CO", "USA", 78495)

```

Table 3 (Login)

* Roommate and Landlord logins.

```
INSERT INTO login (rid, lid, username, passwd, rememb_login)
VALUES ("", "5" ,"Wbiatr", "weovPASSt", "T")

INSERT INTO login (rid, lid, username, passwd, rememb_login)
VALUES ("1", "" ,"EricR", "Egi252#4", "T")

INSERT INTO login (rid, lid, username, passwd, rememb_login)
VALUES ("", "4" ,"CalRev", "pass2345t", "T")

INSERT INTO login (rid, lid, username, passwd, rememb_login)
VALUES ("1", "" ,"kcole", "password123", "T")

INSERT INTO login (rid, lid, username, passwd, rememb_login)
VALUES ("", "3" ,"SBan", "f2fbveb2#", "T")


```

Table 4 (Signup)

* Roommate Signup.
```
INSERT INTO signup (rid, lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("1", "", "Cole Krizek", "kcole", "password123", "colekrizek@gmail.com", "25NOV2022", "M", "1508 Northglen ST Wichita", "KS", "USA", 67220)

INSERT INTO signup (rid, lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("2", "", "Colleen Ann", "AC", "pas2352", "ca@gmail.com", "25FEB2022", "F", "1508 Maple ST Wichita", "KS", "USA", 67220)

INSERT INTO signup (rid, lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("3", "", "Beth Trust", "BethT", "Jerry133f", "Beth@yahoo.com", "02APR2021", "F", "1852 Cherry ST Wichita", "UT", "USA", 54483)

INSERT INTO signup (rid, lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("4", "", "John Robert", "JRob", "t232t2g", "Jrob@outlook.com", "08MAR2021", "M", "2525 Peace ST Abilene", "UT", "USA", 57883)

INSERT INTO signup (rid, lid, name, username, passwd, email, created_at, gender, addr, state, country, zip)
VALUES ("5", "", "Brian Carry", "Jzwfg", "coswavbiejt", "Bcar@outlook.com", "18OCT2020", "M", "15912 Dirt ST Parry", "AZ", "USA", 15613)

```
