# SocialInsurance.Germany.Messages

[![Build-Status](https://img.shields.io/teamcity/https/build.service-dataline.de:8081/s/OpenSource_SocialInsuranceGermanyMessages.svg?label=TeamCity)](https://build.service-dataline.de:8081/viewType.html?buildTypeId=OpenSource_SocialInsuranceGermanyMessages&guest=1)

Klassen und [BeanIO](https://github.com/FubarDevelopment/beanio-net)-Mappings für SV-Meldedateien.

# Lizenz

Die Bibliothek steht unter der [MIT-Lizenz](LICENSE.md)
und wurde bereitgestellt von:

[![DATALINE](http://www.dataline.de/images/Logo_kleiner.png)](http://www.dataline.de)

# Grundlegender Aufbau

## Klassen

Die Klassen für die SV-Meldungen sind im ```Pocos```-Projekt enthalten und sind direkt
nach den Datensätzen und Bausteinen in der Dokumentation benannt.

Die Datensätze beginnen mit ```DS``` und implementieren immer das Interface ```IDatensatz```,
während die Datenbausteine mit ```DB``` beginnen und immer das Interface ```IDatenbaustein```
implementieren.

## [BeanIO](https://github.com/FubarDevelopment/beanio-net)-Mappings

Die [BeanIO](https://github.com/FubarDevelopment/beanio-net)-Mappings sind im ```Mappings```-Projekt
enthalten. Ein ```System.IO.Stream```-Objekt für alle Mappings aller Meldungen kann über
```Meldungen.LoadMeldungen``` erstellt werden.
