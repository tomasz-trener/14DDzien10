<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicyServer.aspx.cs" Inherits="P02AplikacjaZawodnicy.ZawodnicyServer" %>

  <div class="col-md-12">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title"> Simple Table</h4>
              </div>
              <div class="card-body">
                <div class="table-responsive">
                  <table class="table">
                    <thead class=" text-primary">
                      <th>
                        Imie i Nazwisko
                      </th>
                      <th>
                        Kraj
                      </th>
                      <th>
                        Wzrost
                      </th>
                      <th >
                        Data urodzenia
                      </th>
                    </thead>
                    <tbody>
 
                        <% foreach (var z in Zawodnicy)
                            { %>

                            <tr>
                                <td><%= z.ImieNazwisko %></td>
                                <td><%=z.Kraj %></td>
                                <td><%=z.Wzrost %></td>
                                <td><%=z.DataUrFormat %></td>
                            </tr>

                          <%     } %>

                    </tbody>
                  </table>
                </div>

                  <div id="dvStronicowanie">
                      <img id="btnLewo" src="images/arrowLeft.png" style="width:20px; cursor:grabbing" />       
                      <span>Strona: </span>
                      <input id="txtStrona" type="text" value="<%=AktualnaStrona %>" style="width:20px" />
                      <span>z</span>
                      <span id="lblLiczbaStron"><%= LiczbaStron %></span>
                      <img id="btnPrawo" src="images/arrowRight.png" style="width:20px;cursor:grabbing" />
                  </div>

              </div>
            </div>
          </div>
