import 'package:flutter/material.dart';
import 'package:calculator/Input_field.dart';

class Functionalities {

  TextEditingController firstnumber = new TextEditingController();
  TextEditingController secondnumber = new TextEditingController();

  var getvalue_firstnumber;
  var getvalue_secondnumber;

  var output = 0;
  int Value()
  {
    return output;
  }
  void add() {
    getvalue_firstnumber = int.parse(firstnumber.text);
    getvalue_secondnumber = int.parse(secondnumber.text);
    output = getvalue_firstnumber + getvalue_secondnumber;
  }

  void substarct() {
    getvalue_firstnumber = int.parse(firstnumber.text);
    getvalue_secondnumber = int.parse(secondnumber.text);
    output = getvalue_firstnumber - getvalue_secondnumber;
  }

  void multiply() {
    getvalue_firstnumber = int.parse(firstnumber.text);
    getvalue_secondnumber = int.parse(secondnumber.text);
    output = getvalue_firstnumber * getvalue_secondnumber;
  }

  void division() {
    getvalue_firstnumber = int.parse(firstnumber.text);
    getvalue_secondnumber = int.parse(secondnumber.text);
    output = getvalue_firstnumber ~/ getvalue_secondnumber;
  }
  void clear()
  {
    firstnumber.text = "";
    secondnumber.text = "";
    output = 0;
  }
}