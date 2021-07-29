import React, { useEffect, useState } from 'react'
import { CardPais } from './CardPais';


export const Paises = () => {
    useEffect(() => {
        obtener();
      }, [])
const [Ciudad, setCiudad] = useState([])

    const obtener = async() => {
        const apipais = 'https://restcountries.eu/rest/v2/all'
        const rest = await fetch(apipais)
        const datos = await rest.json()
        console.log(datos);
        const distribuye = datos.map(tmppais => {
             return{
                id       : parseInt(tmppais.numericCode),
                Bandera    :tmppais.flag,
                nombre    :tmppais.name,
                region    :tmppais.region,
                subregion :tmppais.subregion}
        })

        setCiudad(distribuye)


    } 
    console.log(Ciudad);


    return (
        <div className="container">
            <div className="row">
            <div className="col">


            {
            Ciudad.map(ciuda=>(
              <CardPais 
                 key={ciuda.id}
                {...ciuda} 
                />
            ))
          }</div>
            </div>
        </div>
    )
}
