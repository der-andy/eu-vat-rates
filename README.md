# EU VAT Rates (current and historical)

This repository contains a JSON file with the VAT rates of all EU countries as well as a [LINQPad](http://linqpad.net) snippet that creates the JSON from C# code.

Source: http://ec.europa.eu/taxation_customs/resources/documents/taxation/vat/how_vat_works/rates/vat_rates_en.pdf (Part VIII: The evolution of the VAT rates applicable in the member states.)

Remarks:
 * Reduced rates are always ordered from highest to lowest.
 * Increased and parking rates are always ordered from lowest to highest.
 * France: To avoid miscalculations, the rates from 1968-01-01 to 1969-12-31 are omitted because they were applied to the gross price instead of the net price.

Last update: 2015-05-11 (rates from 2015-01-01)
