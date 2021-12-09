# FizzBuzz
procedure fizzbuzz
  For i := 1 to 100 do
    set print_number to true;
    If i is divisible by 3 then
      print "Fizz";
      set print_number to false;
    If i is divisible by 5 then
      print "Buzz";
      set print_number to false;
    If print_number, print i;
    print a newline;
  end




procedure AvailabilityCheck(Geraetetyp, Entleihbeginn, Entleihdauer)

    geraeteliste = getGeraeteListe(Geraetetyp)

    foreach geraeteId in geraeteliste
        buchungsdaten = getResDat(geraeteId)
        if (buchungsdaten[1] < Entleihbeginn)
            return GeraeteId
        endif
    endfor

    return 0
endprocedure
        



procedure AvailabilityCheck(Geraetetyp, Entleihbeginn, Entleihdauer)
    geraeteliste = getGeraeteListe(Geraetetyp)
    foreach geraeteId in 
        buchungsdaten = getResDat(geraeteId)
        if buchungsdaten at index 1 smaller than Entleihbeginn then
            return GeraeteId
        endif
    endforeach

    return 0
endprocedure
