import 'package:flutter/material.dart';
import 'package:calculator/Input_field.dart';
void main() {
  runApp(VisualView());
}

class VisualView extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        backgroundColor: Colors.grey,
        appBar: AppBar(
          title: Text("Calculator"),
        ),
        body: InputFields(),
      ),
    );
  }
}






