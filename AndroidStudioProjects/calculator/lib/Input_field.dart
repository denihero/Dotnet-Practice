import 'package:flutter/material.dart';
import 'action_fnc.dart';

class InputFields extends StatefulWidget {
  @override
  _InputFieldsState createState() => _InputFieldsState();
}

class _InputFieldsState extends State<InputFields> {
  Functionalities functionalities = new Functionalities();
  @override
  Widget build(BuildContext context) {
    return Container(
      padding: EdgeInsets.all(40.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        children: <Widget>[
          TextField(
            controller: functionalities.firstnumber,
            keyboardType: TextInputType.number,
            decoration: InputDecoration(
              border: OutlineInputBorder(),
              labelText: 'First number',
            ),
          ),
          SizedBox(
            height: 20,
          ),
          TextField(
            controller: functionalities.secondnumber,
            keyboardType: TextInputType.number,
            decoration: InputDecoration(
              border: OutlineInputBorder(),
              labelText: 'Second number',
            ),
          ),
          SizedBox(
            height: 20,
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: <Widget>[
              ElevatedButton(
                child: Text(
                    "+",
                    style: TextStyle(fontSize: 30, fontWeight: FontWeight.bold)),
                onPressed: () {
                  setState(() {
                    functionalities.add();
                  });
                },
              ),
              ElevatedButton(
                  child: Text(
                      "-",
                      style: TextStyle(fontSize: 30, fontWeight: FontWeight.bold)),
                  onPressed: () {
                      setState(() {
                        functionalities.substarct();
                      });
                  }
              )
            ],
          ),

          Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: <Widget>[
              ElevatedButton(
                child: Text(
                  "*",
                  style: TextStyle(fontSize: 30, fontWeight: FontWeight.bold),
                ),
                onPressed: () {
                  setState(() {
                    functionalities.multiply();
                  });
                },
              ),
              ElevatedButton(
                child: Text(
                  "/",
                  style: TextStyle(fontSize: 30, fontWeight: FontWeight.bold),
                ),
                onPressed: () {
                  setState(() {
                    functionalities.division();
                  });
                },
              )
            ],
          ),

          SizedBox(
            height: 10,
          ),
          Text(
            "${functionalities.output}",
            style: TextStyle(fontSize: 30),
          ),
          ElevatedButton(
              child: Text(
                "Clear",
                style: TextStyle(
                    fontSize: 20,
                    fontWeight: FontWeight.bold),),
            onPressed: () {
                setState(() {
                  functionalities.clear();
                });
            },
          )
        ],
      ),
    );
  }
}

